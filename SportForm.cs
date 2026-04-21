using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School_Management_System
{
    public partial class SportForm : Form
    {
        public SportForm()
        {
            InitializeComponent();
            this.Load += SportForm_Load;
        }


        public void SportForm_Load(object? sender, EventArgs e)
        {
            LoadStudents();
        }

        public void LoadSport()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;Trustservercertificate=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sport", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void LoadStudents()
        {
            try
            {


                using (SqlConnection conn = new SqlConnection(
                    "Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = "SELECT StudentID,fname + ' ' + mname + ' ' + sname AS StudentName FROM StudentsData";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox4.DataSource = dt;
                    comboBox4.DisplayMember = "StudentID";
                    comboBox4.ValueMember = "StudentID";
                    comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox4.SelectedIndex = -1; // optional: no selection at start


                    comboBox5.DataSource = dt;
                    comboBox5.DisplayMember = "StudentName";
                    comboBox5.ValueMember = "StudentName";
                    comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox5.SelectedIndex = -1; // optional: no selection at start



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;Trustservercertificate=True"))
                {
                    conn.Open();
                    string query = @"INSERT INTO Sport(StudentID,PlayerName,SportCategory,Team,CoachName)VALUES(@StudentID,@PlayerName,@SportCategory,@Team,@CoachName)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", comboBox4.SelectedValue);
                        cmd.Parameters.AddWithValue("@PlayerName", comboBox5.Text);
                        cmd.Parameters.AddWithValue("@SportCategory", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@Team", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@CoachName", comboBox3.Text);
                        cmd.ExecuteNonQuery();

                    }

                }

                MessageBox.Show("Sports Details Submitted Successfully!");
                LoadSport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Register Player!" + ex.Message);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedValue == null || comboBox4.SelectedValue is DataRowView)
                return;
            int StudentID;
            if (int.TryParse(comboBox4.SelectedValue.ToString(), out StudentID))
            {
                return;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedValue == null || comboBox5.SelectedValue is DataRowView)
                return;
            int StudentID;
            if (int.TryParse(comboBox5.SelectedValue.ToString(), out StudentID))
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadSport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
