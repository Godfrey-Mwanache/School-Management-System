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
    public partial class ExaminationForm : Form
    {
        public ExaminationForm()
        {
            InitializeComponent();
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private string GetGrade(double marks)
        {
            if (marks >= 81) return "A";
            else if (marks >= 70) return "B";
            else if (marks >= 60) return "C";
            else if (marks >= 50) return "D";
            else if (marks >= 40) return "E";
            else if (marks >= 35) return "S";
            else return "F";
        }

        private void CalculatePositions()
        {
            List<(int RowIndex, int Total)> results = new List<(int, int)>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var val = dataGridView1.Rows[i].Cells["Total"].Value;

                if (val != null && int.TryParse(val.ToString(), out int total))
                {
                    results.Add((i, total));
                }
            }

            // Sort descending
            results.Sort((a, b) => b.Total.CompareTo(a.Total));

            // Assign positions
            for (int i = 0; i < results.Count; i++)
            {
                dataGridView1.Rows[results[i].RowIndex]
                    .Cells["Position"].Value = i + 1;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (!dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name.Contains("_Grade")
         && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name != "StudentID"
         && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name != "StudentName"
         && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name != "level"
         && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name != "Total"
         && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name != "OverallGrade"
         && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name != "Position")
            {
                TextBox tb = e.Control as TextBox;

                if (tb != null)
                {
                    tb.KeyPress -= TextBox_KeyPress;
                    tb.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void LoadStudents()
        {
            using (SqlConnection con = new SqlConnection("Data Source=localhost;initial catalog=SchoolDB;integrated security=true;Trustservercertificate=True"))
            {
                con.Open();

                string query = "SELECT StudentID, fname + ' ' + sname AS StudentName,level FROM StudentsData WHERE level=@level";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@level", combolevel.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (dr.Read())
                {
                    int rowIndex = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowIndex].Cells["StudentID"].Value = dr["StudentID"];
                    dataGridView1.Rows[rowIndex].Cells["StudentName"].Value = dr["StudentName"];
                    dataGridView1.Rows[rowIndex].Cells["level"].Value = dr["level"];


                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exampanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void heading_Click(object sender, EventArgs e)
        {

        }

        private void ExaminationForm_Load(object sender, EventArgs e)
        {

        }



        private void combolevel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["level"] != null)
                {
                    row.Cells["level"].Value = combolevel.Text;
                }
            }
        }

        private void comboterm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboexamtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonexamdetails_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(combolevel.Text))
            {
                MessageBox.Show("Please select a level first.");
                return;
            }

            try
            {

                using (SqlConnection con = new SqlConnection("Data Source=Localhost;initial catalog=SchoolDB;integrated security=True;Trustservercertificate=True"))
                {
                    con.Open();
                    string query = @"INSERT INTO Exam(ExamType,level,Term)VALUES(@ExamType,@level,@Term)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ExamType", comboexamtype.Text);
                        cmd.Parameters.AddWithValue("@level", combolevel.Text);
                        cmd.Parameters.AddWithValue("@Term", comboterm.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Examination Data submitted Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Save Examination details" + ex.Message);
            }
        }

        private void buttonentermarks_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            // Student columns
            dataGridView1.Columns.Add("StudentID", "Student ID");
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("level", "Level");

            List<string> subjects = new List<string>();

            using (SqlConnection con = new SqlConnection("Data Source=localhost;initial catalog=SchoolDB;integrated security=true;Trustservercertificate=True"))
            {
                con.Open();

                string query = "SELECT departmentName AS Subject FROM Department WHERE Level=@level";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@level", combolevel.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string subject = dr["Subject"].ToString();
                    subjects.Add(subject);

                    // Marks column
                    dataGridView1.Columns.Add(subject, subject);
                    dataGridView1.Columns[subject].ReadOnly = false;


                    // Grade column for each subject
                    dataGridView1.Columns.Add(subject + "_Grade", subject + " Grade");
                    dataGridView1.Columns[subject + "_Grade"].ReadOnly = true;
                }
            }

            // Final columns
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.Columns.Add("OverallGrade", "Overall Grade");
            dataGridView1.Columns.Add("Position", "Position");

            LoadStudents();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            int total = 0;
            int subjectCount = 0;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                // Skip non-mark columns
                if (col.Name == "StudentID" || col.Name == "StudentName" ||
                    col.Name == "level" ||
                    col.Name.Contains("_Grade") || col.Name == "Total" ||
                    col.Name == "OverallGrade" || col.Name == "Position")
                    continue;

                var cellValue = dataGridView1.Rows[rowIndex].Cells[col.Name].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int marks))
                {
                    total += marks;
                    subjectCount++;
                    if (marks > 100)
                    {
                        MessageBox.Show("Marks cannot exceed 100");
                        dataGridView1.Rows[rowIndex].Cells[col.Name].Value = 0;
                        return;
                    }
                    // Set subject grade
                    string grade = GetGrade(marks);
                    dataGridView1.Rows[rowIndex].Cells[col.Name + "_Grade"].Value = grade;
                }

            }

            // Set total
            dataGridView1.Rows[rowIndex].Cells["Total"].Value = total;

            // Average
            double average = subjectCount > 0 ? (double)total / subjectCount : 0;

            // Overall grade
            string overallGrade = GetGrade((int)average);
            dataGridView1.Rows[rowIndex].Cells["OverallGrade"].Value = overallGrade;

            // Recalculate positions
            CalculatePositions();
        }

        private void buttonsavemarks_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection("Data Source=localhost;initial catalog=SchoolDB;integrated security=true;Trustservercertificate=True"))
    {
        con.Open();

        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (row.Cells["StudentID"].Value == null)
                continue;

            int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name == "StudentID" || col.Name == "StudentName" ||
                    col.Name == "level" ||
                    col.Name.Contains("_Grade") || col.Name == "Total" ||
                    col.Name == "OverallGrade" || col.Name == "Position")
                    continue;

                var markCell = row.Cells[col.Name].Value;
                var gradeCell = row.Cells[col.Name + "_Grade"].Value;

                if (markCell != null)
                {
                    int marks = Convert.ToInt32(markCell);
                    string grade = gradeCell?.ToString();

                    string query = @"INSERT INTO Marks 
                        (StudentID,StudentName, Subject, Marks, Grade, ExamType, Term, level)
                        VALUES (@StudentID, @StudentName,@Subject, @Marks, @Grade, @ExamType, @Term, @level)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentId);
                        cmd.Parameters.AddWithValue("@StudentName", row.Cells["StudentName"].Value.ToString());
                        cmd.Parameters.AddWithValue("@Subject", col.Name);
                        cmd.Parameters.AddWithValue("@Marks", marks);
                        cmd.Parameters.AddWithValue("@Grade", grade);
                        cmd.Parameters.AddWithValue("@ExamType", comboexamtype.Text);
                        cmd.Parameters.AddWithValue("@Term", comboterm.Text);
                        cmd.Parameters.AddWithValue("@level", combolevel.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }

    MessageBox.Show("Marks saved successfully!");


        }
    }
}
