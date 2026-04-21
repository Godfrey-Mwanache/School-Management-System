using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class ExaminationForm : Form
    {
        public ExaminationForm()
        {
            InitializeComponent();
            dataGridView1.EditingControlShowing += DataGridView1_EditingControlShowing;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        #region Grade & Points Calculation
        private string GetGrade(double marks)
        {
            if (marks >= 81) return "A";
            if (marks >= 70) return "B";
            if (marks >= 60) return "C";
            if (marks >= 50) return "D";
            if (marks >= 40) return "E";
            if (marks >= 35) return "S";
            return "F";
        }

        private int GetPoints(string grade) => grade switch
        {
            "A" => 1,
            "B" => 2,
            "C" => 3,
            "D" => 4,
            "E" => 5,
            "S" => 6,
            "F" => 7,
            _ => 7
        };
        #endregion

        #region DataGridView Handling
        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colName = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name;

            // Only numeric input for subject marks
            if (!colName.Contains("_Grade") && colName != "StudentID" && colName != "StudentName" &&
                colName != "level" && colName != "Total" && colName != "OverallGrade" && colName != "Position")
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress -= TextBox_KeyPress;
                    tb.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            int total = 0;
            int subjectCount = 0;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name == "StudentID" || col.Name == "StudentName" ||
                    col.Name == "level" || col.Name.Contains("_Grade") || col.Name == "Total" ||
                    col.Name == "OverallGrade" || col.Name == "Position")
                    continue;

                var cellValue = dataGridView1.Rows[rowIndex].Cells[col.Name].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int marks))
                {
                    if (marks > 100)
                    {
                        MessageBox.Show("Marks cannot exceed 100");
                        dataGridView1.Rows[rowIndex].Cells[col.Name].Value = 0;
                        marks = 0;
                    }

                    total += marks;
                    subjectCount++;
                    dataGridView1.Rows[rowIndex].Cells[col.Name + "_Grade"].Value = GetGrade(marks);
                }
            }

            dataGridView1.Rows[rowIndex].Cells["Total"].Value = total;
            double average = subjectCount > 0 ? (double)total / subjectCount : 0;
            dataGridView1.Rows[rowIndex].Cells["OverallGrade"].Value = GetGrade((int)average);

            // Safe call
            CalculatePositions();
        }


        #endregion

        #region Students & Subjects Loading
        private void LoadStudents()
        {
            if (string.IsNullOrEmpty(combolevel.Text)) return;

            using SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT StudentID, fname + ' ' + sname AS StudentName, level FROM StudentsData WHERE level=@level";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@level", combolevel.Text);

            using SqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["StudentID"].Value = dr["StudentID"];
                dataGridView1.Rows[rowIndex].Cells["StudentName"].Value = dr["StudentName"];
                dataGridView1.Rows[rowIndex].Cells["level"].Value = dr["level"];
            }
        }

        private void buttonentermarks_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            // Basic columns
            dataGridView1.Columns.Add("StudentID", "Student ID");
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("level", "Level");

            List<string> subjects = new List<string>();

            using SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT departmentName AS Subject FROM Department WHERE Level=@level";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@level", combolevel.Text);

            using SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string subject = dr["Subject"].ToString();
                subjects.Add(subject);

                dataGridView1.Columns.Add(subject, subject);
                dataGridView1.Columns[subject].ReadOnly = false;

                dataGridView1.Columns.Add(subject + "_Grade", subject + " Grade");
                dataGridView1.Columns[subject + "_Grade"].ReadOnly = true;
            }

            // Additional columns
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.Columns.Add("OverallGrade", "Overall Grade");
            dataGridView1.Columns.Add("Position", "Position");

            LoadStudents();
        }
        #endregion

        #region Exam Details
        private void buttonexamdetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(combolevel.Text))
            {
                MessageBox.Show("Please select a level first.");
                return;
            }

            try
            {
                using SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                string query = "INSERT INTO Exam(ExamType, level, Term) VALUES(@ExamType, @level, @Term)";
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ExamType", comboexamtype.Text);
                cmd.Parameters.AddWithValue("@level", combolevel.Text);
                cmd.Parameters.AddWithValue("@Term", comboterm.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save exam details: " + ex.Message);
                return;
            }

            MessageBox.Show("Examination Data submitted Successfully!");
        }

        private void combolevel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["level"] != null)
                    row.Cells["level"].Value = combolevel.Text;
            }
        }
        #endregion

        #region Marks Saving & Position Calculation
        private void buttonsavemarks_Click(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["StudentID"].Value == null) continue;
                int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.Name == "StudentID" || col.Name == "StudentName" ||
                        col.Name == "level" || col.Name.Contains("_Grade") || col.Name == "Total" ||
                        col.Name == "OverallGrade" || col.Name == "Position")
                        continue;

                    var markCell = row.Cells[col.Name].Value;
                    var gradeCell = row.Cells[col.Name + "_Grade"].Value;
                    var positionCell = row.Cells[col.Name].Value;

                    if (markCell != null)
                    {
                        int marks = Convert.ToInt32(markCell);
                        string grade = gradeCell?.ToString();
                        int position = Convert.ToInt32(positionCell);

                        string query = @"INSERT INTO Marks 
                                        (StudentID, StudentName, Subject, Marks, Grade, ExamType, Term, level,Position)
                                        VALUES (@StudentID, @StudentName, @Subject, @Marks, @Grade, @ExamType, @Term, @level,@Position)";
                        using SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@StudentID", studentId);
                        cmd.Parameters.AddWithValue("@StudentName", row.Cells["StudentName"].Value.ToString());
                        cmd.Parameters.AddWithValue("@Subject", col.Name);
                        cmd.Parameters.AddWithValue("@Marks", marks);
                        cmd.Parameters.AddWithValue("@Grade", grade);
                        cmd.Parameters.AddWithValue("@ExamType", comboexamtype.Text);
                        cmd.Parameters.AddWithValue("@Term", comboterm.Text);
                        cmd.Parameters.AddWithValue("@level", combolevel.Text);
                        cmd.Parameters.AddWithValue("@Position", position);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Marks saved successfully!");
        }

        private void CalculatePositions()
        {
            // Temporarily suspend layout to avoid exceptions
            dataGridView1.SuspendLayout();

            var rowsWithTotal = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow && r.Cells["Total"].Value != null)
                .OrderByDescending(r => Convert.ToInt32(r.Cells["Total"].Value))
                .ToList();

            int position = 1;
            foreach (var row in rowsWithTotal)
            {
                row.Cells["Position"].Value = position;
                position++;
            }

            // No automatic sorting; position column is NotSortable
            dataGridView1.ResumeLayout();
        }
        #endregion

        #region Compute Results
        private void buttoncomputeresult_Click(object sender, EventArgs e)
        {
            // Force recalculation
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                DataGridView1_CellEndEdit(this, new DataGridViewCellEventArgs(0, i));

            List<string[]> results = new List<string[]>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["StudentID"].Value == null) continue;

                string studentId = row.Cells["StudentID"].Value.ToString();
                string studentName = row.Cells["StudentName"].Value.ToString();

                List<int> pointsList = new List<int>();
                List<string> subjects = new List<string>();

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.Name.Contains("_Grade"))
                    {
                        var gradeVal = row.Cells[col.Name].Value;
                        if (gradeVal != null)
                        {
                            string grade = gradeVal.ToString();
                            subjects.Add(col.Name.Replace("_Grade", "") + "-" + grade);
                            pointsList.Add(GetPoints(grade));
                        }
                    }
                }

                pointsList.Sort();
                int totalPoints = pointsList.Take(7).Sum();

                string division = totalPoints <= 9 ? "I" :
                                  totalPoints <= 12 ? "II" :
                                  totalPoints <= 17 ? "III" :
                                  totalPoints <= 19 ? "IV" : "0";

                string subjectGrades = string.Join(", ", subjects);

                results.Add(new string[]
                {
                    studentId,
                    studentName,
                    $"{division}-{totalPoints}",
                    subjectGrades
                });
            }

            // Display inside panel
            ResultForm frm = new ResultForm(results)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                Parent = exampanel
            };
            exampanel.Controls.Clear();
            exampanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        #endregion

        private void buttonSortPositions_Click(object sender, EventArgs e)
        {
            try
            {
                var sortedData = dataGridView1.Rows
       .Cast<DataGridViewRow>()
       .Where(r => !r.IsNewRow && r.Cells["Position"].Value != null)
       .OrderBy(r => Convert.ToInt32(r.Cells["Position"].Value))
       .Select(r => dataGridView1.Columns
           .Cast<DataGridViewColumn>()
           .Select(c => r.Cells[c.Name].Value)
           .ToArray())
       .ToList();

                // Clear rows
                dataGridView1.Rows.Clear();

                // Re-add safely
                foreach (var rowValues in sortedData)
                {
                    dataGridView1.Rows.Add(rowValues);
                }
                MessageBox.Show("Students Arranged by position, Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Position Rearrangement Failed!" + ex.Message);
            }
        }

        private void buttonviewresult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboexamtype.Text) || string.IsNullOrEmpty(combolevel.Text) || string.IsNullOrEmpty(comboterm.Text))
            {
                MessageBox.Show("Please select Exam Type, Class, and Term before searching.");
                return;
            }

            // Clear previous grid
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            List<string> subjects = new List<string>();

            using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();

                // Get all subjects for the selected class
                string querySubjects = "SELECT departmentName AS Subject FROM Department WHERE Level=@level";
                using (SqlCommand cmd = new SqlCommand(querySubjects, con))
                {
                    cmd.Parameters.AddWithValue("@level", combolevel.Text);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string subject = dr["Subject"].ToString();
                            subjects.Add(subject);

                            dataGridView1.Columns.Add(subject, subject);
                            dataGridView1.Columns[subject].ReadOnly = false;

                            dataGridView1.Columns.Add(subject + "_Grade", subject + " Grade");
                            dataGridView1.Columns[subject + "_Grade"].ReadOnly = true;
                        }
                    }
                }

                // Basic columns
                dataGridView1.Columns.Add("StudentID", "Student ID");
                dataGridView1.Columns.Add("StudentName", "Student Name");
                dataGridView1.Columns.Add("level", "Level");
                dataGridView1.Columns.Add("Total", "Total");
                dataGridView1.Columns.Add("OverallGrade", "Overall Grade");
                dataGridView1.Columns.Add("Position", "Position");

                // Get saved marks
                string queryMarks = @"
            SELECT StudentID, StudentName, Subject, Marks, Grade, level
            FROM Marks
            WHERE ExamType=@ExamType AND Term=@Term AND level=@level";

                using (SqlCommand cmdMarks = new SqlCommand(queryMarks, con))
                {
                    cmdMarks.Parameters.AddWithValue("@ExamType", comboexamtype.Text);
                    cmdMarks.Parameters.AddWithValue("@Term", comboterm.Text);
                    cmdMarks.Parameters.AddWithValue("@level", combolevel.Text);

                    using (SqlDataReader dr = cmdMarks.ExecuteReader())
                    {
                        Dictionary<int, int> rowMap = new Dictionary<int, int>();

                        while (dr.Read())
                        {
                            int studentId = Convert.ToInt32(dr["StudentID"]);

                            // Add a new row if this student hasn't been added yet
                            if (!rowMap.ContainsKey(studentId))
                            {
                                int rowIndex = dataGridView1.Rows.Add();
                                rowMap[studentId] = rowIndex;

                                dataGridView1.Rows[rowIndex].Cells["StudentID"].Value = studentId;
                                dataGridView1.Rows[rowIndex].Cells["StudentName"].Value = dr["StudentName"].ToString();
                                dataGridView1.Rows[rowIndex].Cells["level"].Value = dr["level"].ToString();
                            }

                            int rowIdx = rowMap[studentId];
                            string subject = dr["Subject"].ToString();
                            int marks = Convert.ToInt32(dr["Marks"]);
                            string grade = dr["Grade"].ToString();

                            if (dataGridView1.Columns.Contains(subject))
                                dataGridView1.Rows[rowIdx].Cells[subject].Value = marks;
                            if (dataGridView1.Columns.Contains(subject + "_Grade"))
                                dataGridView1.Rows[rowIdx].Cells[subject + "_Grade"].Value = grade;
                        }
                    }
                }
            }

            // Update totals, grades, and positions after loading
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridView1_CellEndEdit(this, new DataGridViewCellEventArgs(0, i));
            }

            MessageBox.Show("Marks loaded successfully. You can now edit and update them.");
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["StudentID"].Value == null) continue;
                    int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);

                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        if (col.Name == "StudentID" || col.Name == "StudentName" ||
                            col.Name == "level" || col.Name.Contains("_Grade") || col.Name == "Total" ||
                            col.Name == "OverallGrade" || col.Name == "Position")
                            continue;

                        var markCell = row.Cells[col.Name].Value;
                        var gradeCell = row.Cells[col.Name + "_Grade"].Value;
                        var positionCell = row.Cells["Position"].Value;

                        if (markCell != null)
                        {
                            int marks = Convert.ToInt32(markCell);
                            string grade = gradeCell?.ToString();
                            int position = Convert.ToInt32(positionCell);

                            // Use MERGE pattern: update if exists, else insert
                            string query = @"
                        IF EXISTS (SELECT 1 FROM Marks WHERE StudentID=@StudentID AND Subject=@Subject AND ExamType=@ExamType AND Term=@Term AND level=@level)
                            UPDATE Marks SET Marks=@Marks, Grade=@Grade, Position=@Position WHERE StudentID=@StudentID AND Subject=@Subject AND ExamType=@ExamType AND Term=@Term AND level=@level
                        ELSE
                            INSERT INTO Marks(StudentID, StudentName, Subject, Marks, Grade, ExamType, Term, level, Position)
                            VALUES(@StudentID, @StudentName, @Subject, @Marks, @Grade, @ExamType, @Term, @level, @Position)";

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
                                cmd.Parameters.AddWithValue("@Position", position);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            MessageBox.Show("Marks updated successfully!");
        }
    }
}