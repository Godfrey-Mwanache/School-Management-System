namespace School_Management_System
{
    partial class TimetableForm
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
            label10 = new Label();
            label13 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBox1 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 192, 0);
            label10.Location = new Point(428, 34);
            label10.Name = "label10";
            label10.Size = new Size(210, 32);
            label10.TabIndex = 0;
            label10.Text = "School Timetable";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ButtonHighlight;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(0, 192, 0);
            label13.Location = new Point(428, 516);
            label13.Name = "label13";
            label13.Size = new Size(200, 28);
            label13.TabIndex = 0;
            label13.Text = "Timetable Print Out";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(249, 95);
            label9.Name = "label9";
            label9.Size = new Size(121, 25);
            label9.TabIndex = 1;
            label9.Text = "Timetable ID";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.GradientInactiveCaption;
            textBox4.Location = new Point(428, 92);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Auto Generated";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(309, 31);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(496, 336);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(241, 31);
            textBox5.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(249, 172);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 1;
            label8.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(249, 231);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 1;
            label7.Text = "Class";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(251, 283);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 1;
            label6.Text = "Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(251, 339);
            label11.Name = "label11";
            label11.Size = new Size(54, 25);
            label11.TabIndex = 1;
            label11.Text = "Time";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(251, 394);
            label12.Name = "label12";
            label12.Size = new Size(65, 25);
            label12.TabIndex = 1;
            label12.Text = "Venue";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Class I", "Class II", "Class III", "Class IV", "Class V", "Class VI", "Form I", "Form II", "Firm III", "Form IV", "Form V", "Form VI" });
            comboBox1.Location = new Point(428, 223);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 33);
            comboBox1.TabIndex = 3;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Class Timetable", "Examination Timetable", "Remedial Timetable", "Sports Timetable", "Clubs Timetable", "Religion Timetable", "Breakfast Timetable", "Lunch Timetable", "Dinner Timetable", "Other" });
            comboBox5.Location = new Point(428, 164);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(309, 33);
            comboBox5.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "AM", "PM" });
            comboBox3.Location = new Point(428, 336);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(62, 33);
            comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Room 01", "Room 02", "Room 03", "Room 04", "Room 05", "Room 06", "Room 07", "Room 08", "Room 09", "Room 10", "Room 11", "Room 12", "Room 13", "Room 14", "Room 15", "Dining Hall", "Library", "Meeting Room", "Playing Ground" });
            comboBox4.Location = new Point(428, 386);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(309, 33);
            comboBox4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumSlateBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 547);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1208, 404);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(428, 277);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(309, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(605, 981);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 6;
            button1.Text = "PRINT";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(347, 980);
            button2.Name = "button2";
            button2.Size = new Size(201, 44);
            button2.TabIndex = 6;
            button2.Text = "VIEW TIMETABLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(428, 438);
            button3.Name = "button3";
            button3.Size = new Size(309, 34);
            button3.TabIndex = 7;
            button3.Text = "SAVE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(comboBox5);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 789);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // TimetableForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(980, 789);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TimetableForm";
            Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox5;
        private ComboBox comboBox1;
        private Label label12;
        private Label label11;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label9;
        private Label label13;
        private Label label10;
        private Button button3;
    }
}