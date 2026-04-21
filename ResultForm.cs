using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class ResultForm : Form
    {
        public ResultForm(List<string[]> results)
        {
            InitializeComponent();
            LoadResults(results);
        }

        private void LoadResults(List<string[]> results)
        {
            dataGridViewResults.Columns.Clear();

            dataGridViewResults.Columns.Add("StudentID", "Student ID");
            dataGridViewResults.Columns.Add("StudentName", "Student Name");
            dataGridViewResults.Columns.Add("DivisionPoints", "Division-Points");
            dataGridViewResults.Columns.Add("Subjects", "Subjects (Grades)");

            foreach (var r in results)
            {
                dataGridViewResults.Rows.Add(r);
            }

            // Styling (NECTA look)
            dataGridViewResults.Columns["Subjects"].Width = 400;
            dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResults.RowHeadersVisible = false;

            dataGridViewResults.ColumnHeadersDefaultCellStyle.Font =
                new Font("Arial", 11, FontStyle.Bold);

            HighlightDivision();
        }

        private void HighlightDivision()
        {
            foreach (DataGridViewRow row in dataGridViewResults.Rows)
            {
                if (row.IsNewRow) continue;

                var value = row.Cells["DivisionPoints"].Value;
                if (value == null) continue;

                string div = value.ToString();

                if (div.StartsWith("IV"))
                    row.DefaultCellStyle.BackColor = Color.Orange;
                else if (div.StartsWith("III"))
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                else if (div.StartsWith("II"))
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                else if (div.StartsWith("I"))
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void buttonbacktomarks_Click(object sender, EventArgs e)
        {

            Panel parentPanel = this.Parent as Panel;

            if (parentPanel != null)
            {
                // Clear the panel
                parentPanel.Controls.Clear();

                // Create a new instance of ExaminationForm (or reuse one if you have it stored)
                ExaminationForm examForm = new ExaminationForm();
                examForm.TopLevel = false;
                examForm.FormBorderStyle = FormBorderStyle.None;
                examForm.Dock = DockStyle.Fill;

                parentPanel.Controls.Add(examForm);
                examForm.Show();

                // Close the ResultForm (optional, if it's a child form)
                this.Close();
            }
        }

        private void buttonsavedivision_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=localhost;initial catalog=SchoolDB;integrated security=True;Trustservercertificate=True"))
                {
                    con.Open();

                    foreach (DataGridViewRow row in dataGridViewResults.Rows)
                    {
                        if (row.IsNewRow) continue;

                        // Get values directly (NO looping columns)
                        int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                        string studentName = row.Cells["StudentName"].Value?.ToString();
                        string division = row.Cells["DivisionPoints"].Value?.ToString();

                        if (string.IsNullOrEmpty(division))
                            continue;

                        string query = @"
IF NOT EXISTS (SELECT 1 FROM Division WHERE StudentID = @StudentID)
BEGIN
    INSERT INTO Division (StudentID, StudentName, DivisionPoints)
    VALUES (@StudentID, @StudentName, @DivisionPoints)
END
ELSE
BEGIN
    UPDATE Division
    SET 
        StudentName = @StudentName,
        DivisionPoints = @DivisionPoints
    WHERE StudentID = @StudentID
END";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@StudentID", studentId);
                            cmd.Parameters.AddWithValue("@StudentName", studentName);
                            cmd.Parameters.AddWithValue("@DivisionPoints", division);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Student Divisions Submitted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Submit Divisions! " + ex.Message);
            }
        }

        private void buttonviewtranscript_Click(object sender, EventArgs e)
        {
            Panel parentPanel = this.Parent as Panel;

            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();

                TranscriptControl transcript = new TranscriptControl();
                transcript.Dock = DockStyle.Fill;

                parentPanel.Controls.Add(transcript);
            }
        }
    }
}