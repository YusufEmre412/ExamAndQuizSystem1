namespace ExamAndQuizSystem.Forms
{
    partial class ManageResultsForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelResults = new System.Windows.Forms.Panel();
            this.panelResultsHeader = new System.Windows.Forms.Panel();
            this.labelResultsTitle = new System.Windows.Forms.Label();
            this.flowLayoutResults = new System.Windows.Forms.FlowLayoutPanel();
            this.panelExams = new System.Windows.Forms.Panel();
            this.panelExamsHeader = new System.Windows.Forms.Panel();
            this.labelExamsTitle = new System.Windows.Forms.Label();
            this.flowLayoutExams = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.panelResultsHeader.SuspendLayout();
            this.panelExams.SuspendLayout();
            this.panelExamsHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelMain.Controls.Add(this.panelResults);
            this.panelMain.Controls.Add(this.panelExams);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1238, 729);
            this.panelMain.TabIndex = 0;
            // 
            // panelResults
            // 
            this.panelResults.BackColor = System.Drawing.Color.White;
            this.panelResults.Controls.Add(this.flowLayoutResults);
            this.panelResults.Controls.Add(this.panelResultsHeader);
            this.panelResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelResults.Location = new System.Drawing.Point(600, 0);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(638, 729);
            this.panelResults.TabIndex = 1;
            // 
            // panelResultsHeader
            // 
            this.panelResultsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.panelResultsHeader.Controls.Add(this.labelResultsTitle);
            this.panelResultsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResultsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelResultsHeader.Name = "panelResultsHeader";
            this.panelResultsHeader.Size = new System.Drawing.Size(638, 80);
            this.panelResultsHeader.TabIndex = 2;
            // 
            // labelResultsTitle
            // 
            this.labelResultsTitle.AutoSize = true;
            this.labelResultsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelResultsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelResultsTitle.Location = new System.Drawing.Point(20, 20);
            this.labelResultsTitle.Name = "labelResultsTitle";
            this.labelResultsTitle.Size = new System.Drawing.Size(200, 37);
            this.labelResultsTitle.TabIndex = 0;
            this.labelResultsTitle.Text = "Exam Results";
            // 
            // flowLayoutResults
            // 
            this.flowLayoutResults.AutoScroll = true;
            this.flowLayoutResults.BackColor = System.Drawing.Color.White;
            this.flowLayoutResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutResults.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutResults.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutResults.Name = "flowLayoutResults";
            this.flowLayoutResults.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutResults.Size = new System.Drawing.Size(638, 649);
            this.flowLayoutResults.TabIndex = 1;
            this.flowLayoutResults.WrapContents = false;
            // 
            // panelExams
            // 
            this.panelExams.BackColor = System.Drawing.Color.White;
            this.panelExams.Controls.Add(this.flowLayoutExams);
            this.panelExams.Controls.Add(this.panelExamsHeader);
            this.panelExams.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelExams.Location = new System.Drawing.Point(0, 0);
            this.panelExams.Name = "panelExams";
            this.panelExams.Size = new System.Drawing.Size(600, 729);
            this.panelExams.TabIndex = 0;
            // 
            // panelExamsHeader
            // 
            this.panelExamsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.panelExamsHeader.Controls.Add(this.labelExamsTitle);
            this.panelExamsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExamsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelExamsHeader.Name = "panelExamsHeader";
            this.panelExamsHeader.Size = new System.Drawing.Size(600, 80);
            this.panelExamsHeader.TabIndex = 1;
            // 
            // labelExamsTitle
            // 
            this.labelExamsTitle.AutoSize = true;
            this.labelExamsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelExamsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelExamsTitle.Location = new System.Drawing.Point(20, 20);
            this.labelExamsTitle.Name = "labelExamsTitle";
            this.labelExamsTitle.Size = new System.Drawing.Size(200, 37);
            this.labelExamsTitle.TabIndex = 0;
            this.labelExamsTitle.Text = "My Exams";
            // 
            // flowLayoutExams
            // 
            this.flowLayoutExams.AutoScroll = true;
            this.flowLayoutExams.BackColor = System.Drawing.Color.White;
            this.flowLayoutExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutExams.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutExams.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutExams.Name = "flowLayoutExams";
            this.flowLayoutExams.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutExams.Size = new System.Drawing.Size(600, 649);
            this.flowLayoutExams.TabIndex = 0;
            this.flowLayoutExams.WrapContents = false;
            // 
            // ManageResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 729);
            this.Controls.Add(this.panelMain);
            this.Name = "ManageResultsForm";
            this.Text = "Manage Results";
            this.Load += new System.EventHandler(this.ManageResultsForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelResults.ResumeLayout(false);
            this.panelResultsHeader.ResumeLayout(false);
            this.panelResultsHeader.PerformLayout();
            this.panelExams.ResumeLayout(false);
            this.panelExamsHeader.ResumeLayout(false);
            this.panelExamsHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Panel panelResultsHeader;
        private System.Windows.Forms.Label labelResultsTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutResults;
        private System.Windows.Forms.Panel panelExams;
        private System.Windows.Forms.Panel panelExamsHeader;
        private System.Windows.Forms.Label labelExamsTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutExams;
    }
}