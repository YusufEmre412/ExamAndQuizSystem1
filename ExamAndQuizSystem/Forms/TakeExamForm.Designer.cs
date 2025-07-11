    namespace ExamAndQuizSystem.Forms
{
    partial class TakeExamForm
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
            this.lblExamTitle = new DevExpress.XtraEditors.LabelControl();
            this.panelQuestionHost = new System.Windows.Forms.Panel();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTitle.Appearance.Options.UseFont = true;
            this.lblExamTitle.Location = new System.Drawing.Point(25, 40);
            this.lblExamTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(110, 25);
            this.lblExamTitle.TabIndex = 0;
            this.lblExamTitle.Text = "labelControl1";
            // 
            // panelQuestionHost
            // 
            this.panelQuestionHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestionHost.Location = new System.Drawing.Point(25, 77);
            this.panelQuestionHost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelQuestionHost.Name = "panelQuestionHost";
            this.panelQuestionHost.Size = new System.Drawing.Size(1589, 657);
            this.panelQuestionHost.TabIndex = 1;
            // 
            // btnPrev
            // 
            this.btnPrev.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnPrev.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrev.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrev.Appearance.Options.UseBackColor = true;
            this.btnPrev.Appearance.Options.UseBorderColor = true;
            this.btnPrev.Appearance.Options.UseFont = true;
            this.btnPrev.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(288, 41);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(274, 77);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Previous";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // btnFinish
            // 
            this.btnFinish.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFinish.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnFinish.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFinish.Appearance.Options.UseBackColor = true;
            this.btnFinish.Appearance.Options.UseBorderColor = true;
            this.btnFinish.Appearance.Options.UseFont = true;
            this.btnFinish.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnFinish.Location = new System.Drawing.Point(902, 41);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(282, 77);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish";
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseBorderColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnNext.Location = new System.Drawing.Point(594, 41);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(282, 77);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Location = new System.Drawing.Point(25, 740);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1589, 143);
            this.panel1.TabIndex = 5;
            // 
            // TakeExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelQuestionHost);
            this.Controls.Add(this.lblExamTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TakeExamForm";
            this.Text = "TakeExamForm";
            this.Load += new System.EventHandler(this.TakeExamForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblExamTitle;
        private System.Windows.Forms.Panel panelQuestionHost;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnFinish;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private System.Windows.Forms.Panel panel1;
    }
}