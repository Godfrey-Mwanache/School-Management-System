namespace School_Management_System
{
    partial class LogoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoutForm));
            panel1 = new Panel();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel3 = new Panel();
            label6 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(45, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 674);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 884);
            panel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(0, 192, 0);
            dateTimePicker1.CalendarMonthBackground = SystemColors.Highlight;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ButtonHighlight;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(13, 777);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(258, 31);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(680, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 824);
            panel3.TabIndex = 6;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(28, 79);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 0;
            label4.Text = "LogOut";
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(631, 188);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(354, 188);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(79, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(189, 60);
            label5.Name = "label5";
            label5.Size = new Size(303, 38);
            label5.TabIndex = 3;
            label5.Text = "School Name ..........   ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 251);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(929, 525);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(619, 157);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 0;
            label3.Text = "Total Classes         ";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DodgerBlue;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(619, 188);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 60);
            textBox4.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DeepSkyBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(344, 176);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 69);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 145);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 0;
            label2.Text = "Total Teachers       ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RoyalBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(68, 176);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 69);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 145);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "Total Students     ";
            label1.Click += label1_Click;
            // 
            // LogoutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 919);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogoutForm";
            Text = "LogoutForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}