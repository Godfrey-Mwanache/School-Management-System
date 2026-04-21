using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using DrawingImage = System.Drawing.Image;

namespace School_Management_System
{
    public partial class FeeForm : Form
    {
        private readonly string connectionString =
            "Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;TrustServerCertificate=True";

        PrintDocument printDocument = new PrintDocument();
        class ReceiptData
        {
            public string Name;
            public string Class;
            public string FeeType;
            public string Amount;
            public string Balance;
            public string Date;
            public string ReceiptNo;
        }
        List<ReceiptData> receipts = new List<ReceiptData>();
        int currentPrintIndex = 0;


        private void LoadAllReceipts()
        {
            receipts.Clear();

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
        ORDER BY s.level, StudentName";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        receipts.Add(new ReceiptData
                        {
                            Name = GetSafeString(reader, "StudentName"),
                            Class = GetSafeString(reader, "StudentClass"),
                            FeeType = GetSafeString(reader, "Feetype"),
                            Amount = GetSafeString(reader, "AmountPaid") + " TZS",
                            Balance = GetSafeString(reader, "Balance") + " TZS",
                            ReceiptNo = GetSafeString(reader, "ReceiptNo"),
                            Date = reader["Paymentdate"] != DBNull.Value
                                ? Convert.ToDateTime(reader["Paymentdate"]).ToString("dd MMM yyyy")
                                : ""
                        });
                    }
                }
            }
        }


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
        private List<ReceiptData> GetReceiptsByFeeType(string feeType)
        {
            List<ReceiptData> list = new List<ReceiptData>();

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
        WHERE f.Feetype = @Feetype
        ORDER BY s.level, StudentName";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Feetype", feeType);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new ReceiptData
                        {
                            Name = GetSafeString(reader, "StudentName"),
                            Class = GetSafeString(reader, "StudentClass"),
                            FeeType = GetSafeString(reader, "Feetype"),
                            Amount = GetSafeString(reader, "AmountPaid") + " TZS",
                            Balance = GetSafeString(reader, "Balance") + " TZS",
                            ReceiptNo = GetSafeString(reader, "ReceiptNo"),
                            Date = reader["Paymentdate"] != DBNull.Value
                                ? Convert.ToDateTime(reader["Paymentdate"]).ToString("dd MMM yyyy")
                                : ""
                        });
                    }
                }
            }

            return list;
        }

        // ===== PRINT =====
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (currentPrintIndex >= receipts.Count)
                return;

            var r = receipts[currentPrintIndex];
            Graphics g = e.Graphics;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 11);

            int y = 20;

            // ===== LOGO =====
            try
            {
                DrawingImage logo = DrawingImage.FromFile("C:\\Users\\hp pc\\Desktop\\logo.png");

                int logoWidth = 80;
                int logoHeight = 80;
                int xLogo = (e.PageBounds.Width - logoWidth) / 2;

                g.DrawImage(logo, xLogo, y, logoWidth, logoHeight);
                y += 90;
            }
            catch { }

            // ===== CENTER TEXT =====
            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;

            g.DrawString("MY SCHOOL NAME", titleFont, Brushes.Black,
                e.PageBounds.Width / 2, y, center);
            y += 30;

            g.DrawString("FEE RECEIPT", headerFont, Brushes.Black,
                e.PageBounds.Width / 2, y, center);
            y += 40;

            // LINE
            g.DrawLine(Pens.Black, 50, y, e.PageBounds.Width - 50, y);
            y += 20;

            // ===== RECEIPT DATA =====
            g.DrawString("Student Name: " + r.Name, bodyFont, Brushes.Black, 50, y); y += 25;
            g.DrawString("Class: " + r.Class, bodyFont, Brushes.Black, 50, y); y += 25;
            g.DrawString("Fee Type: " + r.FeeType, bodyFont, Brushes.Black, 50, y); y += 25;

            g.DrawString("Amount Paid: " + r.Amount, bodyFont, Brushes.Black, 50, y); y += 25;
            g.DrawString("Balance: " + r.Balance, bodyFont, Brushes.Black, 50, y); y += 25;

            g.DrawString("Receipt No: " + r.ReceiptNo, bodyFont, Brushes.Black, 50, y); y += 25;
            g.DrawString("Date: " + r.Date, bodyFont, Brushes.Black, 50, y); y += 25;

            y += 20;
            g.DrawLine(Pens.Black, 50, y, e.PageBounds.Width - 50, y);
            y += 30;

            g.DrawString("Signature: ____________________", bodyFont, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("Generated on: " + DateTime.Now.ToString("dd MMM yyyy HH:mm"),
                bodyFont, Brushes.Black, 50, y);

            // 👉 MOVE TO NEXT STUDENT
            currentPrintIndex++;

            // 👉 MORE PAGES?
            e.HasMorePages = currentPrintIndex < receipts.Count;
        }
        private void GeneratePdf(List<ReceiptData> data, string feeType)
        {
            string filePath = $"Fee_Report_{feeType}_{DateTime.Now.Ticks}.pdf";

            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                // =========================
                // ✅ PAGE 1: SUMMARY TABLE
                // =========================

                document.Add(new Paragraph("SCHOOL NAME")
                    .SimulateBold()
                    .SetFontSize(18)
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph($"Fee Report: {feeType}")
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph("\n"));

                Table table = new Table(6).UseAllAvailableWidth();

                table.AddHeaderCell("Student Name");
                table.AddHeaderCell("Class");
                table.AddHeaderCell("Fee Type");
                table.AddHeaderCell("Amount Paid");
                table.AddHeaderCell("Balance");
                table.AddHeaderCell("Date");

                decimal totalPaid = 0;
                decimal totalBalance = 0;

                foreach (var r in data)
                {
                    table.AddCell(r.Name);
                    table.AddCell(r.Class);
                    table.AddCell(r.FeeType);
                    table.AddCell(r.Amount);
                    table.AddCell(r.Balance);
                    table.AddCell(r.Date);

                    decimal.TryParse(r.Amount.Replace(" TZS", ""), out decimal paid);
                    decimal.TryParse(r.Balance.Replace(" TZS", ""), out decimal bal);

                    totalPaid += paid;
                    totalBalance += bal;
                }

                document.Add(table);

                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph($"Total Paid: {totalPaid} TZS").SimulateBold());
                document.Add(new Paragraph($"Total Balance: {totalBalance} TZS").SimulateBold());

                // =========================
                // ✅ NEXT PAGES: RECEIPTS
                // =========================

                foreach (var r in data)
                {
                    document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                    // OUTER BORDER TABLE (1 column)
                    Table outerTable = new Table(1)
                        .UseAllAvailableWidth();

                    outerTable.SetBorder(new iText.Layout.Borders.SolidBorder(2)); // 🔥 BORDER THICKNESS
                    outerTable.SetPadding(10);

                    // INNER CONTENT
                    Cell cell = new Cell().SetBorder(iText.Layout.Borders.Border.NO_BORDER);

                    // LOGO (optional)
                    try
                    {
                        var imageData = ImageDataFactory.Create("C:\\Users\\hp pc\\Desktop\\logo.png");
                        var logo = new iText.Layout.Element.Image(imageData)
                            .ScaleToFit(80, 80)
                            .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                        cell.Add(logo);
                    }
                    catch { }

                    cell.Add(new Paragraph("SCHOOL NAME")
                        .SimulateBold()
                        .SetFontSize(16)
                        .SetTextAlignment(TextAlignment.CENTER));

                    cell.Add(new Paragraph("FEE RECEIPT")
                        .SimulateBold()
                        .SetTextAlignment(TextAlignment.CENTER));

                    cell.Add(new Paragraph("\n"));

                    cell.Add(new Paragraph("Student Name: " + r.Name));
                    cell.Add(new Paragraph("Class: " + r.Class));
                    cell.Add(new Paragraph("Fee Type: " + r.FeeType));
                    cell.Add(new Paragraph("Amount Paid: " + r.Amount));
                    cell.Add(new Paragraph("Balance: " + r.Balance));
                    cell.Add(new Paragraph("Receipt No: " + r.ReceiptNo));
                    cell.Add(new Paragraph("Date: " + r.Date));

                    cell.Add(new Paragraph("\n"));
                    cell.Add(new Paragraph("Signature: ____________________"));

                    cell.Add(new Paragraph("\nGenerated on: " +
                        DateTime.Now.ToString("dd MMM yyyy HH:mm")));

                    outerTable.AddCell(cell);

                    document.Add(outerTable);
                }
            }

            MessageBox.Show("PDF Generated Successfully!\nSaved at:\n" + filePath);

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }

        // ===== PRINT BUTTON =====


        private void ClassValue_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedValue == null)
                {
                    MessageBox.Show("Select a student first.");
                    return;
                }

                int studentID = Convert.ToInt32(comboBox3.SelectedValue);

                receipts.Clear(); // IMPORTANT
                currentPrintIndex = 0;

                // Add only ONE receipt
                receipts.Add(new ReceiptData
                {
                    Name = NameValue.Text,
                    Class = ClassValue.Text,
                    FeeType = FeeValue.Text,
                    Amount = AmountValue.Text,
                    Balance = BalanceValue.Text,
                    ReceiptNo = ReceiptValue.Text,
                    Date = DateValue.Text
                });

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print(); // 👉 PRINT
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing error: " + ex.Message);
            }
        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllReceipts();

                if (receipts.Count == 0)
                {
                    MessageBox.Show("No receipts found.");
                    return;
                }

                currentPrintIndex = 0;

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print(); // 👉 THIS ACTUALLY PRINTS
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing error: " + ex.Message);
            }
        }



        private void buttonview_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Please select a fee type.");
                    return;
                }

                string feeType = comboBox1.Text;

                var data = GetReceiptsByFeeType(feeType);

                if (data.Count == 0)
                {
                    MessageBox.Show("No records found for this fee type.");
                    return;
                }

                GeneratePdf(data, feeType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonsingleprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedValue == null)
                {
                    MessageBox.Show("Select a student first.");
                    return;
                }

                int studentID = Convert.ToInt32(comboBox3.SelectedValue);

                receipts.Clear(); // IMPORTANT
                currentPrintIndex = 0;

                // Add only ONE receipt
                receipts.Add(new ReceiptData
                {
                    Name = NameValue.Text,
                    Class = ClassValue.Text,
                    FeeType = FeeValue.Text,
                    Amount = AmountValue.Text,
                    Balance = BalanceValue.Text,
                    ReceiptNo = ReceiptValue.Text,
                    Date = DateValue.Text
                });

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print(); // 👉 PRINT
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllReceipts();

                if (receipts.Count == 0)
                {
                    MessageBox.Show("No receipts found.");
                    return;
                }

                currentPrintIndex = 0;

                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = printDocument,
                    Width = 900,
                    Height = 700
                };

                preview.ShowDialog(); // 👈 preview comes with PRINT button built-in
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing error: " + ex.Message);
            }
        }
    }
}