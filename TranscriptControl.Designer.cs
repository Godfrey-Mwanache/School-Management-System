namespace School_Management_System
{
    partial class TranscriptControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTranscript = new Panel();
            buttonpreviewreport = new Button();
            buttonExportPDF = new Button();
            buttonback = new Button();
            dataGridViewTranscript = new DataGridView();
            labeltranscripthead = new Label();
            panelTranscript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTranscript).BeginInit();
            SuspendLayout();
            // 
            // panelTranscript
            // 
            panelTranscript.AutoScroll = true;
            panelTranscript.Controls.Add(buttonpreviewreport);
            panelTranscript.Controls.Add(buttonExportPDF);
            panelTranscript.Controls.Add(buttonback);
            panelTranscript.Controls.Add(dataGridViewTranscript);
            panelTranscript.Controls.Add(labeltranscripthead);
            panelTranscript.Dock = DockStyle.Fill;
            panelTranscript.Location = new Point(0, 0);
            panelTranscript.Name = "panelTranscript";
            panelTranscript.Size = new Size(1324, 1349);
            panelTranscript.TabIndex = 1;
            // 
            // buttonpreviewreport
            // 
            buttonpreviewreport.BackColor = Color.Navy;
            buttonpreviewreport.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonpreviewreport.ForeColor = SystemColors.ButtonHighlight;
            buttonpreviewreport.Location = new Point(531, 1135);
            buttonpreviewreport.Name = "buttonpreviewreport";
            buttonpreviewreport.Size = new Size(243, 57);
            buttonpreviewreport.TabIndex = 4;
            buttonpreviewreport.Text = "Preview Reports";
            buttonpreviewreport.UseVisualStyleBackColor = false;
            buttonpreviewreport.Click += buttonpreviewreport_Click;
            // 
            // buttonExportPDF
            // 
            buttonExportPDF.BackColor = Color.Teal;
            buttonExportPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExportPDF.ForeColor = SystemColors.ButtonFace;
            buttonExportPDF.Location = new Point(873, 1134);
            buttonExportPDF.Name = "buttonExportPDF";
            buttonExportPDF.Size = new Size(210, 57);
            buttonExportPDF.TabIndex = 3;
            buttonExportPDF.Text = "Export to PDF";
            buttonExportPDF.UseVisualStyleBackColor = false;
            buttonExportPDF.Click += buttonExportPDF_Click;
            // 
            // buttonback
            // 
            buttonback.BackColor = Color.LightSkyBlue;
            buttonback.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonback.Location = new Point(303, 1135);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(147, 57);
            buttonback.TabIndex = 2;
            buttonback.Text = "Back <<";
            buttonback.UseVisualStyleBackColor = false;
            buttonback.Click += buttonback_Click;
            // 
            // dataGridViewTranscript
            // 
            dataGridViewTranscript.BackgroundColor = Color.White;
            dataGridViewTranscript.BorderStyle = BorderStyle.None;
            dataGridViewTranscript.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTranscript.Location = new Point(14, 188);
            dataGridViewTranscript.Name = "dataGridViewTranscript";
            dataGridViewTranscript.RowHeadersWidth = 62;
            dataGridViewTranscript.Size = new Size(1294, 881);
            dataGridViewTranscript.TabIndex = 1;
            dataGridViewTranscript.CellContentClick += dataGridViewTranscript_CellContentClick;
            // 
            // labeltranscripthead
            // 
            labeltranscripthead.AutoSize = true;
            labeltranscripthead.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltranscripthead.ForeColor = Color.Navy;
            labeltranscripthead.Location = new Point(526, 87);
            labeltranscripthead.Name = "labeltranscripthead";
            labeltranscripthead.Size = new Size(290, 38);
            labeltranscripthead.TabIndex = 0;
            labeltranscripthead.Text = "Generated Transcript";
            // 
            // TranscriptControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTranscript);
            Name = "TranscriptControl";
            Size = new Size(1324, 1349);
            panelTranscript.ResumeLayout(false);
            panelTranscript.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTranscript).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTranscript;
        private Label labeltranscripthead;
        private DataGridView dataGridViewTranscript;
        private Button buttonback;
        private Button buttonExportPDF;
        private Button buttonpreviewreport;
    }
}
