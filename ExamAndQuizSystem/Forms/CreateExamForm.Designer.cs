namespace ExamAndQuizSystem.Forms
{
    partial class CreateExamForm
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
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDate = new DevExpress.XtraEditors.DateEdit();
            this.btnSaveExam = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(545, 179);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Exam Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(677, 176);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Properties.Appearance.Options.UseFont = true;
            this.txtTitle.Size = new System.Drawing.Size(125, 34);
            this.txtTitle.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Location = new System.Drawing.Point(611, 296);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 28);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // dateEditDate
            // 
            this.dateEditDate.EditValue = new System.DateTime(2025, 5, 21, 0, 0, 0, 0);
            this.dateEditDate.Location = new System.Drawing.Point(677, 294);
            this.dateEditDate.Name = "dateEditDate";
            this.dateEditDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEditDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Properties.TodayDate = new System.DateTime(2025, 5, 21, 19, 11, 49, 0);
            this.dateEditDate.Size = new System.Drawing.Size(125, 30);
            this.dateEditDate.TabIndex = 3;
            // 
            // btnSaveExam
            // 
            this.btnSaveExam.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveExam.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.btnSaveExam.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveExam.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSaveExam.Appearance.Options.UseBackColor = true;
            this.btnSaveExam.Appearance.Options.UseFont = true;
            this.btnSaveExam.Appearance.Options.UseForeColor = true;
            this.btnSaveExam.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSaveExam.ImageOptions.Image = global::ExamAndQuizSystem.Properties.Resources.save;
            this.btnSaveExam.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSaveExam.Location = new System.Drawing.Point(677, 399);
            this.btnSaveExam.Name = "btnSaveExam";
            this.btnSaveExam.Size = new System.Drawing.Size(112, 44);
            this.btnSaveExam.TabIndex = 4;
            this.btnSaveExam.Text = "Save";
            this.btnSaveExam.Click += new System.EventHandler(this.btnSaveExam_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(677, 235);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(125, 34);
            this.textEdit1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(601, 236);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 31);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Time:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(808, 236);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 31);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "(in minutes)";
            // 
            // CreateExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.btnSaveExam);
            this.Controls.Add(this.dateEditDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateExamForm";
            this.Text = "CreateExamForm";
            this.Load += new System.EventHandler(this.CreateExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.DateEdit dateEditDate;
        private DevExpress.XtraEditors.SimpleButton btnSaveExam;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}