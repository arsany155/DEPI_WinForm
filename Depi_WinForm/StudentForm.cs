using Depi_WinForm.Migrations;
using Microsoft.EntityFrameworkCore;
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
    public partial class StudentForm : Form
    {
        Test_Context db = new Test_Context();
        List<Student> students = new List<Student>();
        Student SelectedStudent = new Student();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            students = db.Students.ToList();
            dataGridView1.DataSource = students.Select(a => new
            {
                Id = a.Id,
                First_Name = a.First_Name,
                Last_Name = a.Last_Name,
                Address = a.Address,
                Age = a.Age,
                DeptId = a.DeptId
            }).ToList(); 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = string.Empty;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            int deletedId;
            if (int.TryParse(textBox6.Text, out deletedId))
            {
                var deletedRecord = db.Students.FirstOrDefault(a => a.Id == deletedId);

                if (deletedRecord != null)
                {
                    db.Students.Remove(deletedRecord);
                    db.SaveChanges();
                    MessageBox.Show("The data deleted successfully");
                    students = db.Students.ToList();
                    dataGridView1.DataSource = students.Select(a => new
                    {
                        Id = a.Id,
                        First_Name = a.First_Name,
                        Last_Name = a.Last_Name,
                        Address = a.Address,
                        Age = a.Age,
                        DeptId = a.DeptId
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

        private void button5_Click(object sender, EventArgs e)
        {
            //foreach (control control in this.controls)
            //{
            //    if (control is textbox)
            //    {
            //        control.text = string.empty;
            //    }
            //}
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if at least one field is filled
            if (string.IsNullOrWhiteSpace(textBox1.Text) &&
                string.IsNullOrWhiteSpace(textBox2.Text) &&
                string.IsNullOrWhiteSpace(textBox3.Text) &&
                string.IsNullOrWhiteSpace(textBox4.Text) &&
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please enter at least one piece of data before saving.");
                return; // Stop further execution if all fields are empty
            }

            // Assuming SelectedStudent is already initialized and available
            SelectedStudent.First_Name = string.IsNullOrWhiteSpace(textBox1.Text) ? null : textBox1.Text;
            SelectedStudent.Last_Name = string.IsNullOrWhiteSpace(textBox2.Text) ? null : textBox2.Text;
            SelectedStudent.Address = string.IsNullOrWhiteSpace(textBox3.Text) ? null : textBox3.Text;

            if (byte.TryParse(textBox4.Text, out byte age))
            {
                SelectedStudent.Age = age;
            }
            else
            {
                SelectedStudent.Age = null;
            }

            if (int.TryParse(textBox5.Text, out int deptId))
            {
                SelectedStudent.DeptId = deptId;
            }
            else
            {
                SelectedStudent.DeptId = null;
            }

            // Check if student is new or existing based on Id
            if (SelectedStudent.Id == 0)
            {
                bool isExistingStudent = db.Students.Any(s => s.First_Name == SelectedStudent.First_Name && s.Last_Name == SelectedStudent.Last_Name && s.Id != SelectedStudent.Id);

                if (isExistingStudent)
                {
                    MessageBox.Show("This student already exists in the database.");
                }
                else
                {
                    InsertData(SelectedStudent);
                    MessageBox.Show("The data was added successfully.");
                }
            }
            else
            {
                UpdateData(SelectedStudent);
                MessageBox.Show("The data was updated successfully.");
            }

            db.SaveChanges();

            // Refresh DataGridView
            students = db.Students.ToList();
            dataGridView1.DataSource = students.Select(a => new
            {
                Id = a.Id,
                First_Name = a.First_Name,
                Last_Name = a.Last_Name,
                Address = a.Address,
                Age = a.Age,
                DeptId = a.DeptId
            }).ToList();

            // Clear text boxes
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        public void InsertData(Student student)
        {
            db.Students.Add(student);
        }

        public void UpdateData(Student student)
        {
            var oldStudent = db.Students.FirstOrDefault(x => x.Id == student.Id);
            oldStudent.First_Name = student.First_Name;
            oldStudent.Last_Name = student.Last_Name;
            oldStudent.Address = student.Address;
            oldStudent.Age = student.Age;
            oldStudent.DeptId = student.DeptId;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = e.RowIndex;
            SelectedStudent = students[rowindex];
            textBox1.Text = SelectedStudent.First_Name;
            textBox2.Text = SelectedStudent.Last_Name;
            textBox3.Text = SelectedStudent.Address;
            textBox4.Text = SelectedStudent.Age.ToString();
            textBox5.Text = SelectedStudent.DeptId.ToString();
        }
    }
}
