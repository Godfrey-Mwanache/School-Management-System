using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School_Management_System
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }
        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                // ✅ Validate Gender
                string gender = "";
                if (radioButton1.Checked)
                    gender = "Male";
                else if (radioButton2.Checked)
                    gender = "Female";
                else
                {
                    MessageBox.Show("Please select gender");
                    return;
                }

                // ✅ Validate Images
                if (pictureBox1.ImageLocation == null)
                {
                    MessageBox.Show("Please upload Teacher's photo first");
                    return;
                }



                // ✅ Database Connection
                using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = @"INSERT INTO TeachersData(firstName,lastName,gender,department,phone1,phone2,email,address1,address2,district,region,marrital,picturePath)VALUES(@firstName,@lastName,@gender,@department,@phone1,@phone2,@email,@address1,@address2,@district,@region,@marrital,@picturePath)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // ✅ Teacher Info
                        cmd.Parameters.AddWithValue("@firstName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@lastName", textBox3.Text);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@department", comboBox1.Text);

                        cmd.Parameters.AddWithValue("@phone1", textBox4.Text);
                        cmd.Parameters.AddWithValue("@phone2", textBox5.Text);
                        cmd.Parameters.AddWithValue("@email", textBox6.Text);
                        cmd.Parameters.AddWithValue("@address1", textBox7.Text);
                        cmd.Parameters.AddWithValue("@address2", textBox8.Text);
                        cmd.Parameters.AddWithValue("@district", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@region", comboBox3.Text);
                        cmd.Parameters.AddWithValue("@marrital", comboBox4.Text);
                        // ✅ Teacher Image
                        cmd.Parameters.AddWithValue("@picturePath", pictureBox1.ImageLocation);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Details Submitted Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}

