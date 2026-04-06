using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class FeeForm : Form
    {
        private readonly string connectionString =
            "Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True";

        PrintDocument printDocument = new PrintDocument();

        public FeeForm()
        {
            InitializeComponent();
            this.Load += FeeForm_Load;
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        // ===== SAFE READER =====
        private string GetSafeString(SqlDataReader reader, string column)
        {
            return reader[column] == DBNull.Value ? "" : reader[column].ToString();
        }

        // ===== FORM LOAD =====
        private void FeeForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        // ===== LOAD STUDENTS =====
        private void LoadStudents()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT StudentID, fname + ' ' + sname AS FullName FROM StudentsData";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox3.DataSource = dt;
                    comboBox3.DisplayMember = "FullName";
                    comboBox3.ValueMember = "StudentID";
                    comboBox3.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        // ===== DISPLAY RECEIPT =====
        private void DisplayFeeDetails(int studentID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                    SELECT 
                        (s.fname + ' ' + s.mname + ' ' + s.sname) AS StudentName,
                        s.level AS StudentClass,
                        f.Feetype,
                        f.AmountPaid,
                        f.Balance,
                        f.Paymentdate,
                        f.ReceiptNo
                    FROM Fee f
                    INNER JOIN StudentsData s ON f.StudentID = s.StudentID
                    WHERE f.StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            NameValue.Text = GetSafeString(reader, "StudentName");
                            ClassValue.Text = GetSafeString(reader, "StudentClass");
                            FeeValue.Text = GetSafeString(reader, "Feetype");
                            AmountValue.Text = GetSafeString(reader, "AmountPaid") + " TZS";
                            BalanceValue.Text = GetSafeString(reader, "Balance") + " TZS";
                            ReceiptValue.Text = GetSafeString(reader, "ReceiptNo");

                            DateValue.Text = reader["Paymentdate"] != DBNull.Value
                                ? Convert.ToDateTime(reader["Paymentdate"]).ToString("dd MMM yyyy")
                                : "";
                        }
                        else
                        {
                            ClearReceipt();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying fee details: " + ex.Message);
            }
        }

        // ===== CLEAR RECEIPT =====
        private void ClearReceipt()
        {
            NameValue.Text = "";
            ClassValue.Text = "";
            FeeValue.Text = "";
            AmountValue.Text = "";
            BalanceValue.Text = "";
            DateValue.Text = "";
            ReceiptValue.Text = "";
        }

        // ===== INSERT FEE =====
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedValue == null)
                {
                    MessageBox.Show("Select a student.");
                    return;
                }

                if (!decimal.TryParse(textBox2.Text, out decimal amount) ||
                    !decimal.TryParse(textBox3.Text, out decimal balance))
                {
                    MessageBox.Show("Invalid amount values.");
                    return;
                }

                int studentID = Convert.ToInt32(comboBox3.SelectedValue);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                    INSERT INTO Fee (Feetype, AmountPaid, Balance, Paymentdate, ReceiptNo, StudentID)
                    VALUES (@Feetype, @AmountPaid, @Balance, @Paymentdate, @ReceiptNo, @StudentID)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Feetype", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@AmountPaid", amount);
                        cmd.Parameters.AddWithValue("@Balance", balance);
                        cmd.Parameters.AddWithValue("@Paymentdate", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@ReceiptNo", textBox4.Text);
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        cmd.ExecuteNonQuery();
                    }
                }

                DisplayFeeDetails(studentID);
                MessageBox.Show("Saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving fee: " + ex.Message);
            }
        }

        // ===== COMBOBOX CHANGE =====
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue == null || comboBox3.SelectedValue is DataRowView)
                return;

            if (int.TryParse(comboBox3.SelectedValue.ToString(), out int studentID))
            {
                DisplayFeeDetails(studentID);
            }
        }

        // ===== PRINT =====
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 12);

            int y = 50;

            g.DrawString("SCHOOL FEE RECEIPT", titleFont, Brushes.Black, 200, y);
            y += 50;

            g.DrawString("Student Name: " + NameValue.Text, bodyFont, Brushes.Black, 50, y); y += 30;
            g.DrawString("Class: " + ClassValue.Text, bodyFont, Brushes.Black, 50, y); y += 30;
            g.DrawString("Fee Type: " + FeeValue.Text, bodyFont, Brushes.Black, 50, y); y += 30;
            g.DrawString("Amount Paid: " + AmountValue.Text, bodyFont, Brushes.Black, 50, y); y += 30;
            g.DrawString("Balance: " + BalanceValue.Text, bodyFont, Brushes.Black, 50, y); y += 30;
            g.DrawString("Date: " + DateValue.Text, bodyFont, Brushes.Black, 50, y); y += 30;
            g.DrawString("Receipt No: " + ReceiptValue.Text, bodyFont, Brushes.Black, 50, y);

            e.HasMorePages = false;
        }

        // ===== PRINT BUTTON =====
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedValue == null)
                {
                    MessageBox.Show("Select a student first.");
                    return;
                }

                int studentID = Convert.ToInt32(comboBox3.SelectedValue);

                DisplayFeeDetails(studentID);

                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = printDocument,
                    Width = 800,
                    Height = 600
                };

                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing error: " + ex.Message);
            }
        }

        private void ClassValue_Click(object sender, EventArgs e)
        {

        }
    }
}