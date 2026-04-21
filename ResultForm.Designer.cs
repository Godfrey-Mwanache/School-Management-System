namespace School_Management_System
{
    partial class ResultForm
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
            panel1 = new Panel();
            buttonsavedivision = new Button();
            buttonviewtranscript = new Button();
            buttonbacktomarks = new Button();
            label1 = new Label();
            dataGridViewResults = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(buttonsavedivision);
            panel1.Controls.Add(buttonviewtranscript);
            panel1.Controls.Add(buttonbacktomarks);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridViewResults);
            panel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 1692);
            panel1.TabIndex = 0;
            // 
            // buttonsavedivision
            // 
            buttonsavedivision.BackColor = Color.MediumBlue;
            buttonsavedivision.ForeColor = SystemColors.ButtonHighlight;
            buttonsavedivision.Location = new Point(588, 1273);
            buttonsavedivision.Name = "buttonsavedivision";
            buttonsavedivision.Size = new Size(112, 42);
            buttonsavedivision.TabIndex = 3;
            buttonsavedivision.Text = "SAVE";
            buttonsavedivision.UseVisualStyleBackColor = false;
            buttonsavedivision.Click += buttonsavedivision_Click;
            // 
            // buttonviewtranscript
            // 
            buttonviewtranscript.BackColor = Color.MediumSpringGreen;
            buttonviewtranscript.ForeColor = SystemColors.ActiveCaptionText;
            buttonviewtranscript.Location = new Point(779, 1272);
            buttonviewtranscript.Name = "buttonviewtranscript";
            buttonviewtranscript.Size = new Size(226, 43);
            buttonviewtranscript.TabIndex = 2;
            buttonviewtranscript.Text = "Transcript";
            buttonviewtranscript.UseVisualStyleBackColor = false;
            buttonviewtranscript.Click += buttonviewtranscript_Click;
            // 
            // buttonbacktomarks
            // 
            buttonbacktomarks.BackColor = Color.AliceBlue;
            buttonbacktomarks.ForeColor = Color.DarkBlue;
            buttonbacktomarks.Location = new Point(286, 1271);
            buttonbacktomarks.Name = "buttonbacktomarks";
            buttonbacktomarks.Size = new Size(226, 43);
            buttonbacktomarks.TabIndex = 2;
            buttonbacktomarks.Text = "Back to Marks <<";
            buttonbacktomarks.UseVisualStyleBackColor = false;
            buttonbacktomarks.Click += buttonbacktomarks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(528, 64);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 1;
            label1.Text = "Examination Results";
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.BackgroundColor = Color.Azure;
            dataGridViewResults.BorderStyle = BorderStyle.None;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(20, 175);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowHeadersWidth = 62;
            dataGridViewResults.Size = new Size(1234, 892);
            dataGridViewResults.TabIndex = 0;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1293, 1106);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultForm";
            Text = "ResultForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonbacktomarks;
        private Label label1;
        private DataGridView dataGridViewResults;
        private Button buttonviewtranscript;
        private Button buttonsavedivision;
    }
}