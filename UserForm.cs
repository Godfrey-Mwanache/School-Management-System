using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm now = new LoginForm();
            now.Show();
            this.Hide();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
              string.IsNullOrWhiteSpace(textBox3.Text) ||
              string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload User's photo first");
                return;
            }
            try
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(textBox3.Text);
                using (SqlConnection con = new SqlConnection("Data Source=localhost;initial catalog=SchoolDB;Integrated security=True;trustservercertificate=True"))
                {
                    con.Open();
                    string query = @"INSERT INTO UserData(UserName,Password,Role,Email,Photo)VALUES(@UserName,@Password,@Role,@Email,@Photo)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Role", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@Email", textBox4.Text);

                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] imgBytes = ms.ToArray();

                            cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = imgBytes;
                        }
                        cmd.ExecuteNonQuery();
                    }

                }

                MessageBox.Show("Account Created Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Register a User" + ex.Message);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
