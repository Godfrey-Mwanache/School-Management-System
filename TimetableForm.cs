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
    public partial class TimetableForm : Form
    {
        public TimetableForm()
        {
            InitializeComponent();
        }

        public void LoadTimetable()
        {
            using (SqlConnection con = new SqlConnection("Data Source=localhost;initial Catalog=SchoolDB;Integrated Security=True;Trustservercertificate=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Timetable", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadTimetable();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            using (SqlConnection con = new SqlConnection("Data Source=localhost;initial Catalog=SchoolDB;Integrated Security=True;Trustservercertificate=True"))
            {
                con.Open();
                string query = @"INSERT INTO Timetable(category,[class],[Date],[Time],venue)VALUES(@category,@class,@Date,@Time,@venue)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@category", comboBox5.Text);
                    cmd.Parameters.AddWithValue("@class", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Time", textBox5.Text);
                    cmd.Parameters.AddWithValue("@venue", comboBox4.Text);

                    cmd.ExecuteNonQuery();
                    LoadTimetable();
                }

            }
            MessageBox.Show("Timetable Saved Successfully!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
