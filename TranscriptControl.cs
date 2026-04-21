using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace School_Management_System
{
    public partial class TranscriptControl : UserControl
    {
        string connectionString = "Data Source=localhost;initial catalog=SchoolDB;integrated security=True;Trustservercertificate=True";

        public TranscriptControl()
        {
            InitializeComponent();
            this.Load += TranscriptControl_Load;
        }

        private void TranscriptControl_Load(object sender, EventArgs e)
        {
            LoadTranscript();
        }

        private void LoadTranscript()
        {
            string query = @"
            WITH StudentTotals AS (
    SELECT 
        StudentID,
        StudentName,
        level,
        SUM(marks) AS total_marks
    FROM Marks
    GROUP BY StudentID, StudentName, level
),

RankedStudents AS (
    SELECT 
        st.*,
        RANK() OVER (PARTITION BY level ORDER BY total_marks DESC) AS position,
        COUNT(*) OVER (PARTITION BY level) AS total_students  -- ← total students per class
    FROM StudentTotals st
)

SELECT 
    m.StudentID,
    m.StudentName,
    m.level,
    m.Subject,
    m.Marks,
    m.Grade,
    r.total_marks,
    r.Position,
    r.total_students,  -- ← include it here
    ISNULL(d.DivisionPoints, 'N/A') AS DivisionPoints
FROM Marks m
JOIN RankedStudents r ON m.StudentID = r.StudentID
LEFT JOIN Division d ON m.StudentID = d.StudentID
ORDER BY 
    m.level, 
    r.Position, 
    m.StudentID, 
    m.Subject;
            ";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewTranscript.DataSource = dt;

                    StyleGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading transcript: " + ex.Message);
                }
            }
        }

        private void StyleGrid()
        {
            dataGridViewTranscript.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTranscript.RowHeadersVisible = false;
            dataGridViewTranscript.ReadOnly = true;

            // Header styling
            dataGridViewTranscript.ColumnHeadersDefaultCellStyle.Font =
                new Font("Arial", 11, FontStyle.Bold);

            // Rename columns
            if (dataGridViewTranscript.Columns.Contains("student_id"))
                dataGridViewTranscript.Columns["student_id"].HeaderText = "Student ID";

            if (dataGridViewTranscript.Columns.Contains("student_name"))
                dataGridViewTranscript.Columns["student_name"].HeaderText = "Student Name";

            if (dataGridViewTranscript.Columns.Contains("level"))
                dataGridViewTranscript.Columns["level"].HeaderText = "Class";

            if (dataGridViewTranscript.Columns.Contains("subject"))
                dataGridViewTranscript.Columns["subject"].HeaderText = "Subject";

            if (dataGridViewTranscript.Columns.Contains("marks"))
                dataGridViewTranscript.Columns["marks"].HeaderText = "Marks";

            if (dataGridViewTranscript.Columns.Contains("grade"))
                dataGridViewTranscript.Columns["grade"].HeaderText = "Grade";

            if (dataGridViewTranscript.Columns.Contains("total_marks"))
                dataGridViewTranscript.Columns["total_marks"].HeaderText = "Total";

            if (dataGridViewTranscript.Columns.Contains("position"))
                dataGridViewTranscript.Columns["position"].HeaderText = "Position";

            if (dataGridViewTranscript.Columns.Contains("divisionPoints"))
                dataGridViewTranscript.Columns["divisionPoints"].HeaderText = "Division";

            HighlightDivision();
        }

        private void HighlightDivision()
        {
            foreach (DataGridViewRow row in dataGridViewTranscript.Rows)
            {
                if (row.IsNewRow) continue;

                var value = row.Cells["DivisionPoints"].Value; // FIXED
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

        private void dataGridViewTranscript_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Panel parentPanel = this.Parent as Panel;

            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();

                // If you have a previous results list, pass it here
                List<string[]> results = new List<string[]>(); // You can store results globally or fetch again
                ResultForm resultForm = new ResultForm(results)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                parentPanel.Controls.Add(resultForm);
                resultForm.Show();

                // Optionally, dispose this control
                this.Dispose();
            }
        }

        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            if (dataGridViewTranscript.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!");
                return;
            }

            // Group rows by StudentID
            var students = dataGridViewTranscript.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .GroupBy(r => r.Cells["StudentID"].Value.ToString());

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var student in students)
                {
                    var firstRow = student.First();

                    string studentID = firstRow.Cells["StudentID"].Value.ToString();
                    string studentName = firstRow.Cells["StudentName"].Value.ToString();
                    string level = firstRow.Cells["level"].Value.ToString();
                    string total = firstRow.Cells["total_marks"].Value.ToString();
                    string position = firstRow.Cells["Position"].Value.ToString();
                    string totalStudents = firstRow.Cells["total_students"].Value.ToString();
                    string division = firstRow.Cells["DivisionPoints"].Value.ToString();

                    string filePath = System.IO.Path.Combine(
                        folderDialog.SelectedPath,
                        $"{studentName}_{studentID}.pdf"
                    );

                    using (PdfWriter writer = new PdfWriter(filePath))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document document = new Document(pdf))
                    {
                        pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4);

                        // 🖼️ LOGO (PUT YOUR IMAGE PATH HERE)
                        try
                        {
                            var logo = new iText.Layout.Element.Image(
                                iText.IO.Image.ImageDataFactory.Create("C:\\Users\\hp pc\\Desktop\\logo.png"))

                                .ScaleToFit(80, 80)
                            .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                            .SetMarginBottom(10);

                            document.Add(logo);
                        }
                        catch { }

                        // 🏫 SCHOOL NAME
                        document.Add(new Paragraph("MY SCHOOL NAME")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SimulateBold()
                            .SetFontSize(17));

                        document.Add(new Paragraph("EXAM TYPE")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SimulateBold()
                            .SetFontSize(15));

                        document.Add(new Paragraph("STUDENT REPORT CARD")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SimulateBold()
                            .SetFontSize(14));

                        document.Add(new Paragraph("\n"));

                        // 👤 STUDENT INFO
                        document.Add(new Paragraph($"Name: {studentName}"));
                        document.Add(new Paragraph($"Student ID: {studentID}"));
                        document.Add(new Paragraph($"Class: {level}"));

                        document.Add(new Paragraph("\n"));

                        // 📊 SUBJECT TABLE
                        Table table = new Table(3);
                        table.SetWidth(iText.Layout.Properties.UnitValue.CreatePercentValue(100));

                        table.AddHeaderCell("SUBJECT");
                        table.AddHeaderCell("MARKS");
                        table.AddHeaderCell("GRADE");
                        table.SimulateBold();


                        foreach (var row in student)
                        {
                            table.AddCell(row.Cells["Subject"].Value.ToString());
                            table.AddCell(row.Cells["Marks"].Value.ToString());
                            table.AddCell(row.Cells["Grade"].Value.ToString());
                        }

                        document.Add(table);

                        document.Add(new Paragraph("\n"));

                        // 🎯 SUMMARY
                        document.Add(new Paragraph($"Total Marks: {total}"));

                        document.Add(new Paragraph($"Position: {position} / {totalStudents}"));

                        // 🎨 DIVISION COLOR
                        var divParagraph = new Paragraph($"Division: {division}");


                        if (division.StartsWith("I"))
                            divParagraph.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.GREEN);
                        else if (division.StartsWith("II"))
                            divParagraph.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE);
                        else if (division.StartsWith("III"))
                            divParagraph.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.YELLOW);
                        else if (division.StartsWith("IV"))
                            divParagraph.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.ORANGE);
                        else
                            divParagraph.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.RED)
                                        .SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE);

                        document.Add(divParagraph);

                        document.Add(new Paragraph("\n\n"));

                        // ✍️ SIGNATURE SECTION
                        Table signTable = new Table(2);
                        signTable.SetWidth(iText.Layout.Properties.UnitValue.CreatePercentValue(100));

                        signTable.AddCell(new Cell().Add(new Paragraph("______________________\nClass Teacher")));
                        signTable.AddCell(new Cell().Add(new Paragraph("______________________\nHead Teacher")));

                        document.Add(signTable);

                        document.Add(new Paragraph("\nGenerated on: " + DateTime.Now.ToString("yyyy-MM-dd")));
                    }
                }

                MessageBox.Show("All student report cards generated successfully!");
            }


        }

        private void buttonpreviewreport_Click(object sender, EventArgs e)
        {
            if (dataGridViewTranscript.Rows.Count == 0)
            {
                MessageBox.Show("No data to preview!");
                return;
            }

            string filePath = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Batch_Report_Preview.pdf"
            );

            var students = dataGridViewTranscript.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .GroupBy(r => r.Cells["StudentID"].Value.ToString());

            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4);

                foreach (var student in students)
                {
                    var firstRow = student.First();

                    string studentID = firstRow.Cells["StudentID"].Value.ToString();
                    string studentName = firstRow.Cells["StudentName"].Value.ToString();
                    string level = firstRow.Cells["level"].Value.ToString();
                    string total = firstRow.Cells["total_marks"].Value.ToString();
                    string position = firstRow.Cells["Position"].Value.ToString();
                    string totalStudents = firstRow.Cells["total_students"].Value.ToString();
                    string division = firstRow.Cells["DivisionPoints"].Value.ToString();


                    // 🖼️ LOGO (PUT YOUR IMAGE PATH HERE)
                    try
                    {
                        var logo = new iText.Layout.Element.Image(
                            iText.IO.Image.ImageDataFactory.Create("C:\\Users\\hp pc\\Desktop\\logo.png"))

                            .ScaleToFit(80, 80)
                        .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                        .SetMarginBottom(10);

                        document.Add(logo);
                    }
                    catch { }

                    // 🏫 HEADER
                    document.Add(new Paragraph("MY SCHOOL NAME")
                        .SetTextAlignment(TextAlignment.CENTER).SimulateBold().SetFontSize(16));

                    document.Add(new Paragraph("EXAM TYPE")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SimulateBold()
                            .SetFontSize(15));

                    document.Add(new Paragraph("STUDENT REPORT CARD")
                        .SetTextAlignment(TextAlignment.CENTER).SimulateBold().SetFontSize(14));

                    document.Add(new Paragraph("\n"));

                    // 👤 STUDENT INFO
                    document.Add(new Paragraph($"Name: {studentName}"));
                    document.Add(new Paragraph($"Student ID: {studentID}"));
                    document.Add(new Paragraph($"Class: {level}"));

                    document.Add(new Paragraph("\n"));

                    // 📊 TABLE
                    Table table = new Table(3);
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell("SUBJECT");
                    table.AddHeaderCell("MARKS");
                    table.AddHeaderCell("GRADE");

                    foreach (var row in student)
                    {
                        table.AddCell(row.Cells["Subject"].Value.ToString());
                        table.AddCell(row.Cells["Marks"].Value.ToString());
                        table.AddCell(row.Cells["Grade"].Value.ToString());
                    }

                    document.Add(table);

                    document.Add(new Paragraph("\n"));

                    // 🎯 SUMMARY
                    document.Add(new Paragraph($"Total Marks: {total}"));
                    document.Add(new Paragraph($"Position: {position} / {totalStudents}"));
                    document.Add(new Paragraph($"Division: {division}"));

                    document.Add(new Paragraph("\n\n"));

                    // ✍️ SIGNATURES
                    Table signTable = new Table(2);
                    signTable.SetWidth(UnitValue.CreatePercentValue(100));

                    signTable.AddCell(new Cell().Add(new Paragraph("__________________\nClass Teacher")));
                    signTable.AddCell(new Cell().Add(new Paragraph("__________________\nHead Teacher")));

                    document.Add(signTable);

                    // 👉 NEW PAGE FOR NEXT STUDENT
                    document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
                }
            }

            // 🔥 OPEN PDF FOR PREVIEW
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }
    }
}
