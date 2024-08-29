namespace Depi_WinForm
{
    partial class StudentForm
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(327, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(461, 292);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(391, 20);
            button1.Name = "button1";
            button1.Size = new Size(134, 52);
            button1.TabIndex = 1;
            button1.Text = "Get All Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(585, 20);
            button2.Name = "button2";
            button2.Size = new Size(134, 52);
            button2.TabIndex = 2;
            button2.Text = "Clear All Data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(302, 30);
            label1.TabIndex = 3;
            label1.Text = "Enter Student Data or Update:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 7;
            label5.Text = "Age";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(121, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 32);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(121, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 32);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(121, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 32);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(121, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 32);
            textBox4.TabIndex = 11;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(12, 367);
            button3.Name = "button3";
            button3.Size = new Size(110, 40);
            button3.TabIndex = 12;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(12, 312);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 13;
            label6.Text = "Dept Id";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F);
            textBox5.Location = new Point(121, 309);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 32);
            textBox5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(308, 404);
            label7.Name = "label7";
            label7.Size = new Size(206, 25);
            label7.TabIndex = 15;
            label7.Text = "Enter The Id to delete : ";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 11F);
            textBox6.Location = new Point(520, 401);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(89, 32);
            textBox6.TabIndex = 16;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(629, 395);
            button4.Name = "button4";
            button4.Size = new Size(104, 47);
            button4.TabIndex = 17;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F);
            button5.Location = new Point(157, 367);
            button5.Name = "button5";
            button5.Size = new Size(110, 40);
            button5.TabIndex = 18;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // StudentForm
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
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "StudentForm";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Button button4;
        private Button button5;
    }
}