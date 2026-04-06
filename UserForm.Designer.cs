namespace School_Management_System
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(303, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(1271, 735);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(495, 601);
            button4.Name = "button4";
            button4.Size = new Size(172, 47);
            button4.TabIndex = 6;
            button4.Text = "Go to LogIn";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Wheat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(295, 601);
            button3.Name = "button3";
            button3.Size = new Size(172, 47);
            button3.TabIndex = 6;
            button3.Text = "Change Password";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(75, 601);
            button2.Name = "button2";
            button2.Size = new Size(195, 47);
            button2.TabIndex = 6;
            button2.Text = "Create Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(475, 359);
            button1.Name = "button1";
            button1.Size = new Size(140, 34);
            button1.TabIndex = 5;
            button1.Text = "Upload Photo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(475, 207);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Accountant", "Academic", "Teacher", "Doctor", "Student" });
            comboBox1.Location = new Point(228, 439);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 33);
            comboBox1.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(228, 515);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(229, 31);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(228, 362);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 286);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientInactiveCaption;
            textBox1.Location = new Point(228, 204);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Auto Generated";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(229, 31);
            textBox1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(84, 518);
            label7.Name = "label7";
            label7.Size = new Size(64, 28);
            label7.TabIndex = 1;
            label7.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(84, 444);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 1;
            label5.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 365);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 289);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 1;
            label3.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 207);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 1;
            label2.Text = "User ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(267, 80);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 0;
            label1.Text = "User Information";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(-12, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1936, 283);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(46, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 202);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(280, 140);
            label6.Name = "label6";
            label6.Size = new Size(766, 38);
            label6.TabIndex = 0;
            label6.Text = "User Registration to School Management System (SMAS)";
            label6.Click += label6_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1924, 1015);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserForm";
            Text = "www.smas.userregistration.com";
            Load += UserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private Panel panel2;
        private Label label6;
        private PictureBox pictureBox2;
    }
}