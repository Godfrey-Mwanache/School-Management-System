

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace School_Management_System
{
    public partial class Form1 : Form
    {
        string _UserName;
        byte[] _Photo;
        public Form1(string UserName, byte[] Photo)
        {
            InitializeComponent();

            _UserName = UserName;
            _Photo = Photo;
            Loadform(new DashboardForm());

        }

        public void RoundCorners(Control control, int radius)
        {
            int diameter = radius * 2;

            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);




            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        public void MakeCircularWithBorder(PictureBox pb, int borderWidth, Color borderColor)
        {
            // Create a bitmap to hold the circular image with border
            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw circular image
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(borderWidth, borderWidth, pb.Width - 2 * borderWidth, pb.Height - 2 * borderWidth);
                    g.SetClip(path);
                    if (pb.Image != null)
                    {
                        g.DrawImage(pb.Image, borderWidth, borderWidth, pb.Width - 2 * borderWidth, pb.Height - 2 * borderWidth);
                    }
                }

                // Draw the white border
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    g.ResetClip();
                    g.DrawEllipse(pen, borderWidth / 2, borderWidth / 2, pb.Width - borderWidth, pb.Height - borderWidth);
                }
            }

            pb.Image = bmp;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        public void Loadform(Form f)
        {
            panelMain.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panelMain.Controls.Add(f);
            f.Show();

        }
        private int currentImageIndex = 0;
        private string[] imagePaths = new string[]
        {
    @"C:\Users\hp pc\Desktop\schoolcompound.jpg",
    @"C:\Users\hp pc\Desktop\schoolclassroom.jpg"
        };

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex++;

            if (currentImageIndex >= imagePaths.Length)
                currentImageIndex = 0;

            if (pictureBox21.Image != null)
                pictureBox21.Image.Dispose();

            pictureBox21.Image = new Bitmap(imagePaths[currentImageIndex]);
        }
        public void ApplyRounded(Control ctrl, int radius)
        {
            ctrl.Resize += (s, e) => RoundCorners(ctrl, radius);
            RoundCorners(ctrl, radius);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyRounded(panelMain, 20);

            MakeCircularWithBorder(pictureBox1, 3, Color.Green);
            MakeCircularWithBorder(pictureBox22, 3, Color.White); // 5px white border


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox22.Resize += (s, ev) => MakeCircularWithBorder(pictureBox22, 3, Color.White);

            if (imagePaths.Length > 0)
                pictureBox21.Image = new Bitmap(imagePaths[0]);

            timer1.Interval = 2000;
            timer1.Start();





            // ✅ SET USER NAME
            label19.Text = "Welcome - " + _UserName;

            // ✅ SET USER PHOTO
            if (_Photo != null)
            {
                using (MemoryStream ms = new MemoryStream(_Photo))
                {
                    pictureBox22.Image = Image.FromStream(ms);
                }

                // 👉 APPLY CIRCLE AFTER setting image
                MakeCircularWithBorder(pictureBox22, 3, Color.White);
            }
            else
            {
                pictureBox22.Image = null;
            }
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.AliceBlue;
            label2.ForeColor = Color.Black;

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.DodgerBlue;
            label2.ForeColor = Color.White;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.AliceBlue;
            label3.ForeColor = Color.Black;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.DodgerBlue;
            label3.ForeColor = Color.White;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.AliceBlue;
            label4.ForeColor = Color.Black;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.DodgerBlue;
            label4.ForeColor = Color.White;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.AliceBlue;
            label5.ForeColor = Color.Black;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.DodgerBlue;
            label5.ForeColor = Color.White;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.AliceBlue;
            label6.ForeColor = Color.Black;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.DodgerBlue;
            label6.ForeColor = Color.White;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.BackColor = Color.AliceBlue;
            label7.ForeColor = Color.Black;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.DodgerBlue;
            label7.ForeColor = Color.White;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.BackColor = Color.AliceBlue;
            label8.ForeColor = Color.Black;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.DodgerBlue;
            label8.ForeColor = Color.White;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.BackColor = Color.AliceBlue;
            label9.ForeColor = Color.Black;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.DodgerBlue;
            label9.ForeColor = Color.White;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.AliceBlue;
            label10.ForeColor = Color.Black;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.DodgerBlue;
            label10.ForeColor = Color.White;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label11.BackColor = Color.AliceBlue;
            label11.ForeColor = Color.Black;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.BackColor = Color.DodgerBlue;
            label11.ForeColor = Color.White;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.BackColor = Color.AliceBlue;
            label12.ForeColor = Color.Black;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.BackColor = Color.DodgerBlue;
            label12.ForeColor = Color.White;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.BackColor = Color.AliceBlue;
            label13.ForeColor = Color.Black;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.BackColor = Color.DodgerBlue;
            label13.ForeColor = Color.White;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {

            label14.BackColor = Color.AliceBlue;
            label14.ForeColor = Color.Black;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.BackColor = Color.DodgerBlue;
            label14.ForeColor = Color.White;
        }

        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {


        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Loadform(new DashboardForm());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Loadform(new UserForm());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Loadform(new StudentForm());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Loadform(new TeacherForm());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Loadform(new DepartmentForm());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Loadform(new ExaminationForm());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Loadform(new TimetableForm());
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Loadform(new FeeForm());
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Loadform(new TransportForm());
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Loadform(new HealthForm());
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Loadform(new SportForm());
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Loadform(new OtherForm());
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Loadform(new LogoutForm());
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            label19.BackColor = Color.WhiteSmoke;
            label19.ForeColor = Color.Black;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.BackColor = Color.DodgerBlue;
            label19.ForeColor = Color.WhiteSmoke;
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            label20.BackColor = Color.WhiteSmoke;
            label20.ForeColor = Color.Black;
        }

        private void label20_MouseLeave(object sender, EventArgs e)
        {
            label20.BackColor = Color.DodgerBlue;
            label20.ForeColor = Color.WhiteSmoke;
        }

        private void label20_Click(object sender, EventArgs e)
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
                

            }
        }
    }
}

