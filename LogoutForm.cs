using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{

    public partial class LogoutForm : Form
    {
        public LogoutForm()
        {
            InitializeComponent();
            this.Load += LogoutForm_Load;

        }

        

        public void RoundCorners(Control control, int radius)
        {
            int diameter = radius * 2;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        public void ApplyRounded(Control ctrl, int radius)
        {
            ctrl.Resize += (s, e) => RoundCorners(ctrl, radius);
            RoundCorners(ctrl, radius);
        }

        private void LogoutForm_Load(object sender, EventArgs e)
        {
            panel3.Size = new Size(234, 824);
            ApplyRounded(panel3, 15);
            ApplyRounded(textBox1, 7);
            ApplyRounded(textBox2, 7);
            ApplyRounded(textBox4, 7);
            ApplyRounded(label1, 2);
            ApplyRounded(label2, 2);
            ApplyRounded(label3, 2);
        }
        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you really sure you want to logout?", // Message
            "Logout Confirmation",                     // Title
            MessageBoxButtons.YesNo,                  // Buttons
            MessageBoxIcon.Question                   // Icon
        );

            // Check the user’s choice
            if (result == DialogResult.Yes)
            {
                // Code to logout or close the form
                Application.Restart(); // Or any logout logic
            }
            else
            {
                MessageBox.Show("Click Home to Continue");

            }
        }



        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.Black;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.LightBlue;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
