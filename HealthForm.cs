using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class HealthForm : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True";

        public HealthForm()
        {
            InitializeComponent();
            this.Load += HealthForm_Load;
        }

        private void HealthForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        // ✅ LOAD STUDENTS INTO COMBOBOX
        public void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT StudentID,
                                    fname + ' ' + mname + ' ' + sname AS StudentName
                                    FROM StudentsData";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox10.DataSource = dt;
                    comboBox10.DisplayMember = "StudentID"; // ✅ SHOW NAME
                    comboBox10.ValueMember = "StudentID";     // ✅ STORE ID
                    comboBox10.SelectedIndex = -1;


                    comboBox11.DataSource = dt;
                    comboBox11.DisplayMember = "StudentName"; // ✅ SHOW NAME
                    comboBox11.ValueMember = "StudentID";     // ✅ STORE ID
                    comboBox11.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load students: " + ex.Message);
            }
        }

        // ✅ AUTO-FILL NAME WHEN STUDENT SELECTED
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.SelectedItem is DataRowView row)
            {
                comboBox11.Text = row["StudentName"].ToString();
            }
        }

        // ✅ SAVE DATA
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Health
                    (StudentID, PatientName, Class, InsuranceStatus, InsuranceNumber, DateofVisit,
                     HealthUnit, Reason, Symptoms, Allergy, Results, Prescription, MedicineGiven,
                     NextVisit, Instruction, AttendantTitle, AttendantName,
                     ConsulatatioonFee, LabFee, MedFee, TotalCost, PaymentMethod)

                    VALUES
                    (@StudentID, @PatientName, @Class, @InsuranceStatus, @InsuranceNumber, @DateofVisit,
                     @HealthUnit, @Reason, @Symptoms, @Allergy, @Results, @Prescription, @MedicineGiven,
                     @NextVisit, @Instruction, @AttendantTitle, @AttendantName,
                     @ConsulatatioonFee, @LabFee, @MedFee, @TotalCost, @PaymentMethod)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", comboBox10.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@PatientName", comboBox11.Text);
                        cmd.Parameters.AddWithValue("@Class", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@InsuranceStatus", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@InsuranceNumber", textBox3.Text);
                        cmd.Parameters.AddWithValue("@DateofVisit", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@HealthUnit", comboBox3.Text);
                        cmd.Parameters.AddWithValue("@Reason", comboBox4.Text);
                        cmd.Parameters.AddWithValue("@Symptoms", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Allergy", comboBox5.Text);
                        cmd.Parameters.AddWithValue("@Results", textBox5.Text);
                        cmd.Parameters.AddWithValue("@Prescription", comboBox6.Text);
                        cmd.Parameters.AddWithValue("@MedicineGiven", textBox6.Text);
                        cmd.Parameters.AddWithValue("@NextVisit", dateTimePicker2.Value);
                        cmd.Parameters.AddWithValue("@Instruction", textBox7.Text);
                        cmd.Parameters.AddWithValue("@AttendantTitle", comboBox7.Text);
                        cmd.Parameters.AddWithValue("@AttendantName", comboBox9.Text);
                        cmd.Parameters.AddWithValue("@ConsulatatioonFee", textBox9.Text);
                        cmd.Parameters.AddWithValue("@LabFee", textBox10.Text);
                        cmd.Parameters.AddWithValue("@MedFee", textBox11.Text);
                        cmd.Parameters.AddWithValue("@TotalCost", textBox2.Text);
                        cmd.Parameters.AddWithValue("@PaymentMethod", comboBox8.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Patient data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}