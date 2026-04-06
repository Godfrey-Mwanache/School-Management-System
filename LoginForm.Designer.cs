namespace School_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            loginbutton = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 454);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(loginbutton);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(433, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 376);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(44, 193);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(44, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(476, 213);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(281, 318);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(157, 28);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(53, 321);
            label4.Name = "label4";
            label4.Size = new Size(187, 25);
            label4.TabIndex = 4;
            label4.Text = "Don't have Account?";
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.FromArgb(0, 0, 192);
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.ForeColor = SystemColors.ButtonHighlight;
            loginbutton.Location = new Point(119, 248);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(278, 57);
            loginbutton.TabIndex = 3;
            loginbutton.Text = "LOGIN";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            loginbutton.MouseEnter += loginbutton_MouseEnter;
            loginbutton.MouseLeave += loginbutton_MouseLeave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DeepSkyBlue;
            panel4.Location = new Point(92, 235);
            panel4.Name = "panel4";
            panel4.Size = new Size(446, 1);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DeepSkyBlue;
            panel3.Location = new Point(101, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 1);
            panel3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.AliceBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(101, 201);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "                   Enter Password";
            textBox2.Size = new Size(433, 27);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.AliceBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(104, 88);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "               Username /Email address";
            textBox1.Size = new Size(430, 77);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(177, 0);
            label3.Name = "label3";
            label3.Size = new Size(292, 36);
            label3.TabIndex = 0;
            label3.Text = "Login to continue";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(454, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 36);
            label1.TabIndex = 0;
            label1.Text = "Welcome to SMAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(723, 298);
            label2.Name = "label2";
            label2.Size = new Size(559, 39);
            label2.TabIndex = 0;
            label2.Text = "School Management System (SMAS)";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(-1, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1929, 213);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.AliceBlue;
            panel6.Controls.Add(pictureBox5);
            panel6.Location = new Point(-9, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1935, 210);
            panel6.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(73, 23);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(150, 149);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Navy;
            panel7.Controls.Add(panel1);
            panel7.Location = new Point(473, 431);
            panel7.Name = "panel7";
            panel7.Size = new Size(992, 457);
            panel7.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("High Tower Text", 9F);
            label5.ForeColor = Color.AliceBlue;
            label5.Location = new Point(485, 990);
            label5.Name = "label5";
            label5.Size = new Size(477, 21);
            label5.TabIndex = 3;
            label5.Text = " Copyright© 2026, All right reserved. @Mwanache Software";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("High Tower Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(968, 990);
            label6.Name = "label6";
            label6.Size = new Size(477, 21);
            label6.TabIndex = 4;
            label6.Text = " Copyright© 2026, All right reserved. @Mwanache Software";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1924, 1050);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(label2);
            Cursor = Cursors.Hand;
            ForeColor = Color.Navy;
            Name = "LoginForm";
            Text = "SMAS Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel4;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button loginbutton;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label6;
    }
}