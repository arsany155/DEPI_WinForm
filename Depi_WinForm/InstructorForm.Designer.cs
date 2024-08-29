namespace Depi_WinForm
{
    partial class InstructorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F);
            button5.Location = new Point(157, 334);
            button5.Name = "button5";
            button5.Size = new Size(110, 40);
            button5.TabIndex = 37;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(629, 389);
            button4.Name = "button4";
            button4.Size = new Size(104, 47);
            button4.TabIndex = 36;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 11F);
            textBox6.Location = new Point(520, 395);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(89, 32);
            textBox6.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(308, 398);
            label7.Name = "label7";
            label7.Size = new Size(206, 25);
            label7.TabIndex = 34;
            label7.Text = "Enter The Id to delete : ";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F);
            textBox5.Location = new Point(121, 254);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 32);
            textBox5.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(12, 257);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 32;
            label6.Text = "Dept Id : ";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(12, 334);
            button3.Name = "button3";
            button3.Size = new Size(110, 40);
            button3.TabIndex = 31;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(121, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 32);
            textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(121, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 32);
            textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(121, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 32);
            textBox1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(12, 192);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 25;
            label4.Text = "Salary : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 24;
            label3.Text = "InsDegree : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 23;
            label2.Text = "Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(320, 30);
            label1.TabIndex = 22;
            label1.Text = "Enter Instructor Data or Update:";
            // 
            // button2
            // 
            button2.Location = new Point(585, 14);
            button2.Name = "button2";
            button2.Size = new Size(134, 52);
            button2.TabIndex = 21;
            button2.Text = "Clear All Data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(391, 14);
            button1.Name = "button1";
            button1.Size = new Size(134, 52);
            button1.TabIndex = 20;
            button1.Text = "Get All Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(327, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(461, 292);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "InstructorForm";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}