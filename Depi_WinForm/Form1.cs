namespace Depi_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepartmentForm form = new DepartmentForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InstructorForm form = new InstructorForm();
            form.Show();
        }
    }
}
