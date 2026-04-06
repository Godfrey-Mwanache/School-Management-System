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
    public partial class TransportForm : Form
    {
        public TransportForm()
        {
            InitializeComponent();
            this.Load += TransportForm_Load;
        }

        private void TransportForm_Load(object? sender, EventArgs e)
        {
            LoadStudents();

        }


        public void LoadTransport()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;initial Catalog=SchoolDB;Integrated Security=True;Trustservercertificate=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Transport", conn);
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

                    comboBox7.DataSource = dt;
                    comboBox7.DisplayMember = "StudentName";
                    comboBox7.ValueMember = "StudentID";
                    comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox7.SelectedIndex = -1; // optional: no selection at start



                    comboBox9.DataSource = dt;
                    comboBox9.DisplayMember = "StudentID";
                    comboBox9.ValueMember = "StudentName";
                    comboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox9.SelectedIndex = -1; // optional: no selection at start



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = @"INSERT INTO Transport(StudentID,Class,BussNumber,DriverName,RouteArea,PickupStation,TransportFee,parentName,parentphone1,parentphone2,Relationship,StudentName)VALUES(@StudentID,@Class,@BussNumber,@DriverName,@RouteArea,@PickupStation,@TransportFee,@parentName,@parentphone1,@parentphone2,@Relationship,@StudentName)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", comboBox7.SelectedValue);
                        cmd.Parameters.AddWithValue("@Class", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@BussNumber", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@DriverName", comboBox3.Text);
                        cmd.Parameters.AddWithValue("@RouteArea", comboBox4.Text);
                        cmd.Parameters.AddWithValue("@PickupStation", comboBox5.Text);
                        cmd.Parameters.AddWithValue("@TransportFee", comboBox8.Text);
                        cmd.Parameters.AddWithValue("@parentName", textBox4.Text);
                        cmd.Parameters.AddWithValue("@parentphone1", textBox5.Text);
                        cmd.Parameters.AddWithValue("@parentphone2", textBox6.Text);
                        cmd.Parameters.AddWithValue("@Relationship", comboBox6.Text);
                        cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Details Submitted Successfully!");
                LoadTransport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading data: " + ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedValue == null || comboBox7.SelectedValue is DataRowView)
                return;
            int StudentID;
            if (int.TryParse(comboBox7.SelectedValue.ToString(), out StudentID))
            {
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
