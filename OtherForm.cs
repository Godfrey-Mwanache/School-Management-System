using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class OtherForm : Form
    {
        public OtherForm()
        {
            InitializeComponent();
            this.Load += OtherForm_Load;
        }

        public void OtherForm_Load(object sender, EventArgs e)
        {
            LoadOther();
        }

        public void LoadOther()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;Trustservercertificate=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM OtherStaff", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;Trustservercertificate=True"))
                {
                    conn.Open();
                    string query = @"INSERT INTO OtherStaff(Title,StaffName,Position,Department,phone1,phone2,employmentDate,email,address1,address2,district,region,marrital,Religion)VALUES(@Title,@StaffName,@Position,@Department,@phone1,@phone2,@employmentDate,@email,@address1,@address2,@district,@region,@marrital,@Religion)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", comboBox6.Text);
                        cmd.Parameters.AddWithValue("@StaffName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Position", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Department", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@phone1", textBox4.Text);
                        cmd.Parameters.AddWithValue("@phone2", textBox5.Text);
                        cmd.Parameters.AddWithValue("@employmentDate", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@email", textBox6.Text);
                        cmd.Parameters.AddWithValue("@address1", textBox7.Text);
                        cmd.Parameters.AddWithValue("@address2", textBox8.Text);
                        cmd.Parameters.AddWithValue("@district", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@region", comboBox3.Text);
                        cmd.Parameters.AddWithValue("@marrital", comboBox4.Text);
                        cmd.Parameters.AddWithValue("@Religion", comboBox5.Text);
                        cmd.ExecuteNonQuery();
                        ;
                    }
                }
                MessageBox.Show("Staff data are Successful submitted");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Save Staff Details!" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadOther();
        }
    }
}
