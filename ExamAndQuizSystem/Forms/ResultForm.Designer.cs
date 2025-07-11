namespace ExamAndQuizSystem.Forms
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.labelSubtitle);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1282, 120);
            this.panelHeader.TabIndex = 0;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelSubtitle.Location = new System.Drawing.Point(30, 80);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(332, 28);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Click on an exam to view your results";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(225, 54);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "My Grades";
            // 
            // panelResults
            // 
            this.panelResults.AutoScroll = true;
            this.panelResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResults.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelResults.Location = new System.Drawing.Point(0, 120);
            this.panelResults.Name = "panelResults";
            this.panelResults.Padding = new System.Windows.Forms.Padding(20);
            this.panelResults.Size = new System.Drawing.Size(1282, 592);
            this.panelResults.TabIndex = 1;
            this.panelResults.WrapContents = false;
            // 
            // btnBack
            // 
            this.btnBack.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBack.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnBack.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseBorderColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnBack.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnBack.AppearanceHovered.Options.UseBackColor = true;
            this.btnBack.AppearanceHovered.Options.UseBorderColor = true;
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnBack.Location = new System.Drawing.Point(1199, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1282, 712);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.panelHeader);
            this.Name = "ResultForm";
            this.Text = "My Grades";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.FlowLayoutPanel panelResults;
        private DevExpress.XtraEditors.SimpleButton btnBack;
    }
}