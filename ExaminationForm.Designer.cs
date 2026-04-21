namespace School_Management_System
{
    partial class ExaminationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exampanel = new Panel();
            buttonSortPositions = new Button();
            buttoncomputeresult = new Button();
            buttonsavemarks = new Button();
            dataGridView1 = new DataGridView();
            buttonexamdetails = new Button();
            buttonviewresult = new Button();
            buttonentermarks = new Button();
            comboterm = new ComboBox();
            combolevel = new ComboBox();
            comboexamtype = new ComboBox();
            labelterm = new Label();
            labelclass = new Label();
            labelexamtype = new Label();
            exampanelheading = new Label();
            buttonupdate = new Button();
            exampanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // exampanel
            // 
            exampanel.AutoScroll = true;
            exampanel.BackColor = SystemColors.ButtonHighlight;
            exampanel.Controls.Add(buttonSortPositions);
            exampanel.Controls.Add(buttoncomputeresult);
            exampanel.Controls.Add(buttonsavemarks);
            exampanel.Controls.Add(dataGridView1);
            exampanel.Controls.Add(buttonexamdetails);
            exampanel.Controls.Add(buttonupdate);
            exampanel.Controls.Add(buttonviewresult);
            exampanel.Controls.Add(buttonentermarks);
            exampanel.Controls.Add(comboterm);
            exampanel.Controls.Add(combolevel);
            exampanel.Controls.Add(comboexamtype);
            exampanel.Controls.Add(labelterm);
            exampanel.Controls.Add(labelclass);
            exampanel.Controls.Add(labelexamtype);
            exampanel.Controls.Add(exampanelheading);
            exampanel.Location = new Point(0, 0);
            exampanel.Name = "exampanel";
            exampanel.Size = new Size(1289, 2244);
            exampanel.TabIndex = 0;
            // 
            // buttonSortPositions
            // 
            buttonSortPositions.BackColor = Color.Navy;
            buttonSortPositions.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSortPositions.ForeColor = SystemColors.ButtonHighlight;
            buttonSortPositions.Location = new Point(151, 2134);
            buttonSortPositions.Name = "buttonSortPositions";
            buttonSortPositions.Size = new Size(171, 62);
            buttonSortPositions.TabIndex = 6;
            buttonSortPositions.Text = "Sort  Positions";
            buttonSortPositions.UseVisualStyleBackColor = false;
            buttonSortPositions.Click += buttonSortPositions_Click;
            // 
            // buttoncomputeresult
            // 
            buttoncomputeresult.BackColor = Color.SkyBlue;
            buttoncomputeresult.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttoncomputeresult.Location = new Point(943, 2128);
            buttoncomputeresult.Name = "buttoncomputeresult";
            buttoncomputeresult.Size = new Size(242, 63);
            buttoncomputeresult.TabIndex = 5;
            buttoncomputeresult.Text = "COMPUTE RESULTS";
            buttoncomputeresult.UseVisualStyleBackColor = false;
            buttoncomputeresult.Click += buttoncomputeresult_Click;
            // 
            // buttonsavemarks
            // 
            buttonsavemarks.BackColor = Color.Aqua;
            buttonsavemarks.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonsavemarks.Location = new Point(634, 2125);
            buttonsavemarks.Name = "buttonsavemarks";
            buttonsavemarks.Size = new Size(206, 69);
            buttonsavemarks.TabIndex = 5;
            buttonsavemarks.Text = "SAVE MARKS";
            buttonsavemarks.UseVisualStyleBackColor = false;
            buttonsavemarks.Click += buttonsavemarks_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(21, 431);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1233, 1543);
            dataGridView1.TabIndex = 4;
            // 
            // buttonexamdetails
            // 
            buttonexamdetails.BackColor = Color.Cyan;
            buttonexamdetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonexamdetails.ForeColor = Color.MidnightBlue;
            buttonexamdetails.Location = new Point(1087, 217);
            buttonexamdetails.Name = "buttonexamdetails";
            buttonexamdetails.Size = new Size(113, 43);
            buttonexamdetails.TabIndex = 3;
            buttonexamdetails.Text = "Submit";
            buttonexamdetails.UseVisualStyleBackColor = false;
            buttonexamdetails.Click += buttonexamdetails_Click;
            // 
            // buttonviewresult
            // 
            buttonviewresult.BackColor = Color.AliceBlue;
            buttonviewresult.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonviewresult.ForeColor = Color.FromArgb(192, 64, 0);
            buttonviewresult.Location = new Point(600, 364);
            buttonviewresult.Name = "buttonviewresult";
            buttonviewresult.Size = new Size(170, 61);
            buttonviewresult.TabIndex = 3;
            buttonviewresult.Text = "Search Results";
            buttonviewresult.UseVisualStyleBackColor = false;
            buttonviewresult.Click += buttonviewresult_Click;
            // 
            // buttonentermarks
            // 
            buttonentermarks.BackColor = Color.Chartreuse;
            buttonentermarks.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonentermarks.ForeColor = Color.Blue;
            buttonentermarks.Location = new Point(285, 364);
            buttonentermarks.Name = "buttonentermarks";
            buttonentermarks.Size = new Size(170, 61);
            buttonentermarks.TabIndex = 3;
            buttonentermarks.Text = "Enter Marks";
            buttonentermarks.UseVisualStyleBackColor = false;
            buttonentermarks.Click += buttonentermarks_Click;
            // 
            // comboterm
            // 
            comboterm.FormattingEnabled = true;
            comboterm.Items.AddRange(new object[] { "Term I", "Term II" });
            comboterm.Location = new Point(918, 227);
            comboterm.Name = "comboterm";
            comboterm.Size = new Size(121, 33);
            comboterm.TabIndex = 2;
            // 
            // combolevel
            // 
            combolevel.FormattingEnabled = true;
            combolevel.Items.AddRange(new object[] { "Class I", "Class II", "Class III", "Class IV", "Class V", "Class VI", "Form I", "Form II", "Form III", "Form IV", "Form V", "Form VI", "Class I", "Class II", "Class III", "Class IV", "Class V", "Class VI", "Form I", "Form II-Arts", "Form II-Business", "Form III-Arts", "Form III-Business", "Form II-ICT", "Form III-ICT", "Form III-Science", "Form III-Vocational", "Form II-Science", "Form II-Vocational", "Form IV-Arts", "Form IV-Business", "Form IV-ICT", "Form IV-Science", "Form IV-Vocational", "Form V-CBA", "Form V-CBG", "Form V-ECM", "Form V-EGM", "Form V-HGE", "Form V-HGK", "Form V-HGL", "Form V-HKF", "Form V-HKL", "Form VI-CBA", "Form VI-CBG", "Form VI-ECM", "Form VI-EGM", "Form VI-HGE", "Form VI-HGK", "Form VI-HGL", "Form VI-HKF", "Form VI-HKL", "Form VI-PCB", "Form VI-PCM", "Form VI-PGM", "Form VI-PMCs", "Form V-PCB", "Form V-PCM", "Form V-PGM", "Form V-PMCs" });
            combolevel.Location = new Point(603, 227);
            combolevel.Name = "combolevel";
            combolevel.Size = new Size(223, 33);
            combolevel.TabIndex = 2;
            combolevel.SelectedIndexChanged += combolevel_SelectedIndexChanged_1;
            // 
            // comboexamtype
            // 
            comboexamtype.Cursor = Cursors.Hand;
            comboexamtype.FormattingEnabled = true;
            comboexamtype.Items.AddRange(new object[] { "Monthly Examination", "Mid Term Examination", "Terminal Examination", "Annual Examination", "Joint Examination", "Pre Mock Examination", "Pre National Examination", "Special Examination", "Series Examination" });
            comboexamtype.Location = new Point(141, 227);
            comboexamtype.Name = "comboexamtype";
            comboexamtype.Size = new Size(369, 33);
            comboexamtype.TabIndex = 2;
            // 
            // labelterm
            // 
            labelterm.AutoSize = true;
            labelterm.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelterm.ForeColor = Color.FromArgb(0, 192, 0);
            labelterm.Location = new Point(853, 232);
            labelterm.Name = "labelterm";
            labelterm.Size = new Size(59, 28);
            labelterm.TabIndex = 1;
            labelterm.Text = "Term";
            // 
            // labelclass
            // 
            labelclass.AutoSize = true;
            labelclass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelclass.ForeColor = Color.FromArgb(0, 192, 0);
            labelclass.Location = new Point(538, 232);
            labelclass.Name = "labelclass";
            labelclass.Size = new Size(59, 28);
            labelclass.TabIndex = 1;
            labelclass.Text = "Class";
            // 
            // labelexamtype
            // 
            labelexamtype.AutoSize = true;
            labelexamtype.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelexamtype.ForeColor = Color.FromArgb(0, 192, 0);
            labelexamtype.Location = new Point(21, 232);
            labelexamtype.Name = "labelexamtype";
            labelexamtype.Size = new Size(114, 28);
            labelexamtype.TabIndex = 1;
            labelexamtype.Text = "Exam Type";
            // 
            // exampanelheading
            // 
            exampanelheading.AutoSize = true;
            exampanelheading.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exampanelheading.ForeColor = Color.MidnightBlue;
            exampanelheading.Location = new Point(432, 89);
            exampanelheading.Name = "exampanelheading";
            exampanelheading.Size = new Size(348, 38);
            exampanelheading.TabIndex = 0;
            exampanelheading.Text = "Examination Information";
            // 
            // buttonupdate
            // 
            buttonupdate.BackColor = Color.Chartreuse;
            buttonupdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonupdate.ForeColor = Color.Blue;
            buttonupdate.Location = new Point(390, 2129);
            buttonupdate.Name = "buttonupdate";
            buttonupdate.Size = new Size(170, 65);
            buttonupdate.TabIndex = 3;
            buttonupdate.Text = "Update Marks";
            buttonupdate.UseVisualStyleBackColor = false;
            buttonupdate.Click += buttonupdate_Click;
            // 
            // ExaminationForm
            // 
            AutoScroll = true;
            ClientSize = new Size(1282, 1050);
            Controls.Add(exampanel);
            Name = "ExaminationForm";
            Text = "https://www.examination.computevalidation.mwanachesoftware.ac.com";
            exampanel.ResumeLayout(false);
            exampanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);




            // 
            // panel1
            // 





            // label26
            // 


            // 
            // comboBox3
            // 











        }

        #endregion


        private Panel exampanel;
        private ComboBox combolevel;
        private ComboBox comboexamtype;
        private Label labelclass;
        private Label labelexamtype;
        private Label exampanelheading;
        private ComboBox comboterm;
        private Label labelterm;
        private Button buttonviewresult;
        private Button buttonentermarks;
        private DataGridView dataGridView1;
        private Button buttonsavemarks;
        private Button buttoncomputeresult;
        private Button buttonexamdetails;
        private Button buttonSortPositions;
        private Button buttonupdate;
    }
}