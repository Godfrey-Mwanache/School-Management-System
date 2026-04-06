namespace School_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panelMain = new Panel();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            pictureBox18 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            label15 = new Label();
            pictureBox21 = new PictureBox();
            label16 = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label17 = new Label();
            textBox1 = new TextBox();
            label18 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox22 = new PictureBox();
            label19 = new Label();
            label20 = new Label();
            panelMain.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Location = new Point(346, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 1256);
            panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.Honeydew;
            panelMain.Controls.Add(panel2);
            panelMain.Location = new Point(371, 218);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1331, 1040);
            panelMain.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(pictureBox18);
            panel2.Controls.Add(pictureBox19);
            panel2.Controls.Add(pictureBox20);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(pictureBox21);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label18);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1331, 961);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(0, 192, 0);
            dateTimePicker1.CalendarMonthBackground = SystemColors.Highlight;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ButtonHighlight;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(38, 791);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(258, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // pictureBox18
            // 
            pictureBox18.Image = (Image)resources.GetObject("pictureBox18.Image");
            pictureBox18.Location = new Point(798, 179);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(61, 51);
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.TabIndex = 4;
            pictureBox18.TabStop = false;
            pictureBox18.Click += pictureBox18_Click;
            // 
            // pictureBox19
            // 
            pictureBox19.Image = (Image)resources.GetObject("pictureBox19.Image");
            pictureBox19.Location = new Point(470, 176);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(55, 51);
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.TabIndex = 4;
            pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            pictureBox20.Image = (Image)resources.GetObject("pictureBox20.Image");
            pictureBox20.Location = new Point(147, 176);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(62, 48);
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox20.TabIndex = 4;
            pictureBox20.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.ForestGreen;
            label15.Location = new Point(343, 52);
            label15.Name = "label15";
            label15.Size = new Size(303, 38);
            label15.TabIndex = 3;
            label15.Text = "School Name ..........   ";
            // 
            // pictureBox21
            // 
            pictureBox21.Image = (Image)resources.GetObject("pictureBox21.Image");
            pictureBox21.Location = new Point(3, 251);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(1316, 534);
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 2;
            pictureBox21.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ButtonFace;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(789, 145);
            label16.Name = "label16";
            label16.Size = new Size(186, 28);
            label16.TabIndex = 0;
            label16.Text = "Total Classes         ";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DodgerBlue;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(789, 173);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 72);
            textBox4.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DeepSkyBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(457, 173);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 72);
            textBox2.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ButtonFace;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(457, 145);
            label17.Name = "label17";
            label17.Size = new Size(189, 28);
            label17.TabIndex = 0;
            label17.Text = "Total Teachers       ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumSlateBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(137, 173);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 72);
            textBox1.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ButtonFace;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(137, 145);
            label18.Name = "label18";
            label18.Size = new Size(178, 28);
            label18.TabIndex = 0;
            label18.Text = "Total Students     ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(756, 144);
            label1.Name = "label1";
            label1.Size = new Size(497, 38);
            label1.TabIndex = 2;
            label1.Text = "School Management System (SMAS)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DodgerBlue;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 171);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(32, 230);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(32, 297);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(32, 297);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 49);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(32, 366);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 46);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(32, 438);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(49, 38);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(28, 501);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(49, 47);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(28, 577);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(49, 40);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(28, 647);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(49, 38);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 0;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(28, 710);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(49, 49);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 0;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(28, 781);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(49, 49);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 0;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(28, 852);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(49, 49);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 0;
            pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(28, 919);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(49, 49);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 0;
            pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.Location = new Point(28, 994);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(49, 49);
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.TabIndex = 0;
            pictureBox16.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 181);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 0;
            label2.Text = "Home";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(96, 247);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.TabIndex = 0;
            label3.Text = "User";
            label3.Click += label3_Click;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(96, 316);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 0;
            label4.Text = "Student";
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(96, 382);
            label5.Name = "label5";
            label5.Size = new Size(93, 30);
            label5.TabIndex = 0;
            label5.Text = "Teacher";
            label5.Click += label5_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(96, 446);
            label6.Name = "label6";
            label6.Size = new Size(140, 30);
            label6.TabIndex = 0;
            label6.Text = "Department";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(96, 518);
            label7.Name = "label7";
            label7.Size = new Size(141, 30);
            label7.TabIndex = 0;
            label7.Text = "Examination";
            label7.Click += label7_Click;
            label7.MouseEnter += label7_MouseEnter;
            label7.MouseLeave += label7_MouseLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(96, 587);
            label8.Name = "label8";
            label8.Size = new Size(117, 30);
            label8.TabIndex = 0;
            label8.Text = "Timetable";
            label8.Click += label8_Click;
            label8.MouseEnter += label8_MouseEnter;
            label8.MouseLeave += label8_MouseLeave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(96, 655);
            label9.Name = "label9";
            label9.Size = new Size(145, 30);
            label9.TabIndex = 0;
            label9.Text = "Fee Payment";
            label9.Click += label9_Click;
            label9.MouseEnter += label9_MouseEnter;
            label9.MouseLeave += label9_MouseLeave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(96, 729);
            label10.Name = "label10";
            label10.Size = new Size(114, 30);
            label10.TabIndex = 0;
            label10.Text = "Transport";
            label10.Click += label10_Click;
            label10.MouseEnter += label10_MouseEnter;
            label10.MouseLeave += label10_MouseLeave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(96, 800);
            label11.Name = "label11";
            label11.Size = new Size(82, 30);
            label11.TabIndex = 0;
            label11.Text = "Health";
            label11.Click += label11_Click;
            label11.MouseEnter += label11_MouseEnter;
            label11.MouseLeave += label11_MouseLeave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(96, 871);
            label12.Name = "label12";
            label12.Size = new Size(71, 30);
            label12.TabIndex = 0;
            label12.Text = "Sport";
            label12.Click += label12_Click;
            label12.MouseEnter += label12_MouseEnter;
            label12.MouseLeave += label12_MouseLeave;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(96, 938);
            label13.Name = "label13";
            label13.Size = new Size(127, 30);
            label13.TabIndex = 0;
            label13.Text = "Other Staff";
            label13.Click += label13_Click;
            label13.MouseEnter += label13_MouseEnter;
            label13.MouseLeave += label13_MouseLeave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(96, 1013);
            label14.Name = "label14";
            label14.Size = new Size(98, 30);
            label14.TabIndex = 0;
            label14.Text = "Settings";
            label14.MouseEnter += label14_MouseEnter;
            label14.MouseLeave += label14_MouseLeave;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // pictureBox22
            // 
            pictureBox22.Image = (Image)resources.GetObject("pictureBox22.Image");
            pictureBox22.Location = new Point(1700, 30);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(135, 137);
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox22.TabIndex = 4;
            pictureBox22.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.Location = new Point(1388, 53);
            label19.Name = "label19";
            label19.Size = new Size(153, 28);
            label19.TabIndex = 5;
            label19.Text = "Welcome  User";
            label19.MouseEnter += label19_MouseEnter;
            label19.MouseLeave += label19_MouseLeave;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.ButtonHighlight;
            label20.Location = new Point(1576, 121);
            label20.Name = "label20";
            label20.Size = new Size(75, 25);
            label20.TabIndex = 5;
            label20.Text = "LogOut";
            label20.Click += label20_Click;
            label20.MouseEnter += label20_MouseEnter;
            label20.MouseLeave += label20_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1924, 1050);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(pictureBox22);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "https://www.schoolmanagement.mwanache.tz.com";
            Load += Form1_Load;
            panelMain.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelMain;
        
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox17;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private Label label15;
        private PictureBox pictureBox21;
        private Label label16;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label17;
        private TextBox textBox1;
        private Label label18;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox22;
        private Label label19;
        private Label label20;
    }
}
