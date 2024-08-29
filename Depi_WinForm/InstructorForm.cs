using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Depi_WinForm
{
    public partial class InstructorForm : Form
    {
        Test_Context db = new Test_Context();
        List<Instructor> instructors = new List<Instructor>();
        Instructor SelectedInstructor = new Instructor();

        public InstructorForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            instructors = db.Instructors.ToList();
            dataGridView1.DataSource = instructors.Select(i => new
            {
                InsId = i.InsId,
                Name = i.Name,
                InsDegree = i.InsDegree,
                Salary = i.Salary,
                DeptId = i.DeptId
            }).ToList();
        }
        // Clear the grid
        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = string.Empty;
        }

        // Delete an instructor
        private void button4_Click(object sender, EventArgs e)
        {
            int deletedId;
            if (int.TryParse(textBox6.Text, out deletedId))
            {
                var deletedRecord = db.Instructors.FirstOrDefault(i => i.InsId == deletedId);

                if (deletedRecord != null)
                {
                    db.Instructors.Remove(deletedRecord);
                    db.SaveChanges();
                    MessageBox.Show("The data deleted successfully");
                    instructors = db.Instructors.ToList();
                    dataGridView1.DataSource = instructors.Select(i => new
                    {
                        InsId = i.InsId,
                        Name = i.Name,
                        InsDegree = i.InsDegree,
                        Salary = i.Salary,
                        DeptId = i.DeptId
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

        // Clear all textboxes
        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        // Save (insert or update) an instructor
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) &&
                string.IsNullOrWhiteSpace(textBox2.Text) &&
                string.IsNullOrWhiteSpace(textBox3.Text) &&
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please enter at least one piece of data before saving.");
                return; // Stop further execution if all fields are empty
            }

            // Assuming SelectedInstructor is already initialized and available
            SelectedInstructor.Name = string.IsNullOrWhiteSpace(textBox1.Text) ? null : textBox1.Text;
            SelectedInstructor.InsDegree = string.IsNullOrWhiteSpace(textBox2.Text) ? null : textBox2.Text;

            if (decimal.TryParse(textBox3.Text, out decimal salary))
            {
                SelectedInstructor.Salary = salary;
            }
            else
            {
                SelectedInstructor.Salary = null;
            }

            if (int.TryParse(textBox5.Text, out int deptId))
            {
                SelectedInstructor.DeptId = deptId;
            }
            else
            {
                SelectedInstructor.DeptId = null;
            }

            // Check if the instructor is new or existing based on InsId
            if (SelectedInstructor.InsId == 0)
            {
                bool isExistingInstructor = db.Instructors.Any(i => i.Name == SelectedInstructor.Name && i.InsDegree == SelectedInstructor.InsDegree && i.InsId != SelectedInstructor.InsId);

                if (isExistingInstructor)
                {
                    MessageBox.Show("This instructor already exists in the database.");
                }
                else
                {
                    InsertData(SelectedInstructor);
                    MessageBox.Show("The data was added successfully.");
                }
            }
            else
            {
                UpdateData(SelectedInstructor);
                MessageBox.Show("The data was updated successfully.");
            }

            db.SaveChanges();

            // Refresh DataGridView
            instructors = db.Instructors.ToList();
            dataGridView1.DataSource = instructors.Select(i => new
            {
                InsId = i.InsId,
                Name = i.Name,
                InsDegree = i.InsDegree,
                Salary = i.Salary,
                DeptId = i.DeptId
            }).ToList();

            // Clear text boxes
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;

        }
        public void InsertData(Instructor instructor)
        {
            db.Instructors.Add(instructor);
        }

        public void UpdateData(Instructor instructor)
        {
            var oldInstructor = db.Instructors.FirstOrDefault(i => i.InsId == instructor.InsId);
            oldInstructor.Name = instructor.Name;
            oldInstructor.InsDegree = instructor.InsDegree;
            oldInstructor.Salary = instructor.Salary;
            oldInstructor.DeptId = instructor.DeptId;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            SelectedInstructor = instructors[rowIndex];
            textBox1.Text = SelectedInstructor.Name;
            textBox2.Text = SelectedInstructor.InsDegree;
            textBox3.Text = SelectedInstructor.Salary?.ToString();
            textBox5.Text = SelectedInstructor.DeptId?.ToString();
        }
    }

}
