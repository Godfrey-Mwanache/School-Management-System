using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class DashboardForm : Form
    {

        public DashboardForm()
        {
            InitializeComponent();
            this.Load += DashboardForm_Load;
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

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            ApplyRounded(textBox1, 7);
            ApplyRounded(textBox2, 7);
            ApplyRounded(textBox4, 7);
            ApplyRounded(label1, 2);
            ApplyRounded(label2, 2);
            ApplyRounded(label3, 2);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
