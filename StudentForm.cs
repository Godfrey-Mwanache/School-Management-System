using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace School_Management_System
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void ClearAll(Control Parent)
        {
            foreach (Control c in Parent.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
                else if (c is PictureBox)
                    ((PictureBox)c).Image = null;
                if (c.HasChildren)
                    ClearAll(c);
            }
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
                    MessageBox.Show("Please upload Student photo first");
                    return;
                }

                if (pictureBox2.ImageLocation == null)
                {
                    MessageBox.Show("Please upload Parent photo first");
                    return;
                }

                // ✅ Database Connection
                using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = @"INSERT INTO StudentsData 
                    (fname,mname,sname,gender,PicturePath1,dob,level,admission,add1,add2,subject,
                     pname,parentphone1,parentphone2,parentadd1,parentadd2,district,region,citizenship,PicturePath2) 
                    VALUES
                    (@fname,@mname,@sname,@gender,@PicturePath1,@dob,@level,@admission,@add1,@add2,@subject,
                     @pname,@parentphone1,@parentphone2,@parentadd1,@parentadd2,@district,@region,@citizenship,@PicturePath2)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // ✅ Student Info
                        cmd.Parameters.AddWithValue("@fname", textBox2.Text);
                        cmd.Parameters.AddWithValue("@mname", textBox3.Text);
                        cmd.Parameters.AddWithValue("@sname", textBox4.Text);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@PicturePath1", pictureBox1.ImageLocation);
                        cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@level", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@admission", dateTimePicker2.Value);
                        cmd.Parameters.AddWithValue("@add1", textBox5.Text);
                        cmd.Parameters.AddWithValue("@add2", textBox6.Text);
                        cmd.Parameters.AddWithValue("@subject", comboBox4.Text);

                        // ✅ Parent Info
                        cmd.Parameters.AddWithValue("@pname", textBox7.Text);
                        cmd.Parameters.AddWithValue("@parentphone1", textBox8.Text);
                        cmd.Parameters.AddWithValue("@parentphone2", textBox9.Text);
                        cmd.Parameters.AddWithValue("@parentadd1", textBox10.Text);
                        cmd.Parameters.AddWithValue("@parentadd2", textBox11.Text);

                        // ✅ Location
                        cmd.Parameters.AddWithValue("@district", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@region", comboBox3.Text);
                        cmd.Parameters.AddWithValue("@citizenship", textBox12.Text);

                        // ✅ Parent Image
                        cmd.Parameters.AddWithValue("@PicturePath2", pictureBox2.ImageLocation);

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

        // ✅ Upload Student Image
        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        // ✅ Upload Parent Image
        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAll(this);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}