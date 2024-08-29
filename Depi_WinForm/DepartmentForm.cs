using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depi_WinForm
{
    public partial class DepartmentForm : Form
    {
        Test_Context db = new Test_Context();
        List<Department> departments = new List<Department>();
        Department SelectedDepartment = new Department();
        public DepartmentForm()
        {
            InitializeComponent();
        }

        //get all data in grid
        private void button1_Click(object sender, EventArgs e)
        {
            departments = db.Departments.ToList();
            dataGridView1.DataSource = departments.Select(d => new
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description,
                Location = d.Location,
                Dept_Manager = d.Dept_Manager,
                HireDate = d.HireDate
            }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //clear grid
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = string.Empty;
        }

        //delete button
        private void button4_Click(object sender, EventArgs e)
        {
            int deletedId;
            if (int.TryParse(textBox6.Text, out deletedId))
            {
                var deletedRecord = db.Departments.FirstOrDefault(d => d.Id == deletedId);

                if (deletedRecord != null)
                {
                    db.Departments.Remove(deletedRecord);
                    db.SaveChanges();
                    MessageBox.Show("The data deleted successfully");
                    departments = db.Departments.ToList();
                    dataGridView1.DataSource = departments.Select(d => new
                    {
                        Id = d.Id,
                        Name = d.Name,
                        Description = d.Description,
                        Location = d.Location,
                        Dept_Manager = d.Dept_Manager,
                        HireDate = d.HireDate
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
            }
        }

        //clear all text boxs
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        //save (insert and update)
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) &&
                string.IsNullOrWhiteSpace(textBox2.Text) &&
                string.IsNullOrWhiteSpace(textBox3.Text) &&
                string.IsNullOrWhiteSpace(textBox4.Text) &&
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please enter at least one piece of data before saving.");
                return; // Stop further execution if all fields are empty
            }

            // Assuming SelectedDepartment is already initialized and available
            SelectedDepartment.Name = string.IsNullOrWhiteSpace(textBox1.Text) ? null : textBox1.Text;
            SelectedDepartment.Description = string.IsNullOrWhiteSpace(textBox2.Text) ? null : textBox2.Text;
            SelectedDepartment.Location = string.IsNullOrWhiteSpace(textBox3.Text) ? null : textBox3.Text;

            if (int.TryParse(textBox4.Text, out int deptManager))
            {
                SelectedDepartment.Dept_Manager = deptManager;
            }
            else
            {
                SelectedDepartment.Dept_Manager = null;
            }

            if (DateTime.TryParse(textBox5.Text, out DateTime hiringDate))
            {
                SelectedDepartment.HireDate = hiringDate;
            }
            else
            {
                SelectedDepartment.HireDate = null;
            }

            // Check if the department is new or existing based on Id
            if (SelectedDepartment.Id == 0)
            {
                bool isExistingDepartment = db.Departments.Any(d => d.Name == SelectedDepartment.Name && d.Description == SelectedDepartment.Description && d.Id != SelectedDepartment.Id);

                if (isExistingDepartment)
                {
                    MessageBox.Show("This department already exists in the database.");
                }
                else
                {
                    InsertData(SelectedDepartment);
                    MessageBox.Show("The data was added successfully.");
                }
            }
            else
            {
                UpdateData(SelectedDepartment);
                MessageBox.Show("The data was updated successfully.");
            }

            db.SaveChanges();

            // Refresh DataGridView
            departments = db.Departments.ToList();
            dataGridView1.DataSource = departments.Select(d => new
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description,
                Location = d.Location,
                Dept_Manager = d.Dept_Manager,
                HireDate = d.HireDate
            }).ToList();

            // Clear text boxes
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }


        public void InsertData(Department department)
        {
            db.Departments.Add(department);
        }

        public void UpdateData(Department department)
        {
            var oldDepartment = db.Departments.FirstOrDefault(d => d.Id == department.Id);
            oldDepartment.Name = department.Name;
            oldDepartment.Description = department.Description;
            oldDepartment.Location = department.Location;
            oldDepartment.Dept_Manager = department.Dept_Manager;
            oldDepartment.HireDate = department.HireDate;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = e.RowIndex;
            SelectedDepartment = departments[rowindex];
            textBox1.Text = SelectedDepartment.Name;
            textBox2.Text = SelectedDepartment.Description;
            textBox3.Text = SelectedDepartment.Location;
            textBox4.Text = SelectedDepartment.Dept_Manager?.ToString();
            textBox5.Text = SelectedDepartment.HireDate?.ToString();
        }
    }
}
