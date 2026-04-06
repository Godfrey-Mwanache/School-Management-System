using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace School_Management_System
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


                // ✅ Database Connection
                using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = @"INSERT INTO Department(departmentName,HoD,Description,level)VALUES(@departmentName,@HoD,@Description,@level)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                    // ✅ Department Info
                    cmd.Parameters.AddWithValue("@departmentName", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@HoD",textBox2.Text);
                    cmd.Parameters.AddWithValue("@Description", textBox3.Text);
                    cmd.Parameters.AddWithValue("@level", comboBox2.Text);
                    cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Details Submitted Successfully!");

            }
            
        }
    }
    

