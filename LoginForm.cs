using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using BCrypt.Net;

namespace School_Management_System
{



    public partial class LoginForm : Form
    {

        public LoginForm()
        {



            try
            {
                InitializeComponent();
                this.Load += LoginForm_Load;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        bool isPassswordVisible = false;
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

        public void ApplyRounded(Control ctrl, int radius)
        {
            ctrl.Resize += (s, e) => RoundCorners(ctrl, radius);
            RoundCorners(ctrl, radius);
        }
        public void MakeCircularWithBorder(PictureBox pb, int borderSize, Color borderColor)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(path);

            pb.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    e.Graphics.DrawEllipse(pen,
                        borderSize / 2,
                        borderSize / 2,
                        pb.Width - borderSize,
                        pb.Height - borderSize);
                }
            };
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.Size = new Size(988, 454);
            ApplyRounded(panel1, 15);
            ApplyRounded(loginbutton, 10);
            ApplyRounded(panel7, 18);

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            MakeCircularWithBorder(pictureBox5, 3, Color.DodgerBlue);

            // keep it circular when resized
            pictureBox5.Resize += (s, ev) =>
                MakeCircularWithBorder(pictureBox5, 3, Color.LightSkyBlue);

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isPassswordVisible == false)
            {
                textBox2.UseSystemPasswordChar = false;
                isPassswordVisible = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                isPassswordVisible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserForm user = new UserForm();
            user.Show();
            this.Hide();
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Pleas Enter email and password to Login");
                    return;
                }

                using (SqlConnection con = new SqlConnection("Data Source=localhost;initial catalog=SchoolDB;Integrated security=True;Trustservercertificate=True"))
                {
                    con.Open();
                    string query = "SELECT UserName,Password, Photo FROM UserData WHERE Email=@Email";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@Email", textBox1.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["Password"].ToString();
                                string inputPassword = textBox2.Text;

                                // ✅ Verify password correctly
                                bool isMatch = BCrypt.Net.BCrypt.Verify(inputPassword, storedHash);

                                if (isMatch)
                                {
                                    string UserName = reader["UserName"].ToString();

                                    byte[] photoBytes = null;
                                    if (reader["Photo"] != DBNull.Value)
                                        photoBytes = (byte[])reader["Photo"];

                                    MessageBox.Show("Login Successful!");

                                    Form1 dash = new Form1(UserName, photoBytes);
                                    dash.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Wrong password!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email not found!");
                            }


                        }



                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginbutton_MouseEnter(object sender, EventArgs e)
        {
            loginbutton.BackColor = Color.LightGreen;
            loginbutton.ForeColor = Color.Blue;
        }

        private void loginbutton_MouseLeave(object sender, EventArgs e)
        {
            loginbutton.BackColor = Color.RoyalBlue;
            loginbutton.ForeColor = Color.White;
        }
    }
}
