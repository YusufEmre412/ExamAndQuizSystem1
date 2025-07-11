namespace ExamAndQuizSystem.Forms
{
    partial class ManageQuestionsForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblExamTitle = new DevExpress.XtraEditors.LabelControl();
            this.cmbQuestionType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelMCQ = new System.Windows.Forms.Panel();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelFill = new System.Windows.Forms.Panel();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelCode = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtExpectedAnswer = new System.Windows.Forms.TextBox();
            this.btnAddQuestion = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQuestionType.Properties)).BeginInit();
            this.panelMCQ.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.panelCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Exam";
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExamTitle.Appearance.Options.UseFont = true;
            this.lblExamTitle.Location = new System.Drawing.Point(79, 48);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(9, 21);
            this.lblExamTitle.TabIndex = 1;
            this.lblExamTitle.Text = "-";
            // 
            // cmbQuestionType
            // 
            this.cmbQuestionType.Location = new System.Drawing.Point(648, 141);
            this.cmbQuestionType.Name = "cmbQuestionType";
            this.cmbQuestionType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbQuestionType.Properties.Appearance.Options.UseFont = true;
            this.cmbQuestionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbQuestionType.Properties.Items.AddRange(new object[] {
            "mcq",
            "fill",
            "code"});
            this.cmbQuestionType.Size = new System.Drawing.Size(191, 30);
            this.cmbQuestionType.TabIndex = 2;
            this.cmbQuestionType.SelectedIndexChanged += new System.EventHandler(this.cmbQuestionType_SelectedIndexChanged);
            // 
            // panelMCQ
            // 
            this.panelMCQ.Controls.Add(this.txtOption4);
            this.panelMCQ.Controls.Add(this.txtOption3);
            this.panelMCQ.Controls.Add(this.txtOption2);
            this.panelMCQ.Controls.Add(this.txtOption1);
            this.panelMCQ.Controls.Add(this.rbOption4);
            this.panelMCQ.Controls.Add(this.rbOption3);
            this.panelMCQ.Controls.Add(this.rbOption2);
            this.panelMCQ.Controls.Add(this.rbOption1);
            this.panelMCQ.Controls.Add(this.labelControl2);
            this.panelMCQ.Location = new System.Drawing.Point(478, 366);
            this.panelMCQ.Name = "panelMCQ";
            this.panelMCQ.Size = new System.Drawing.Size(550, 207);
            this.panelMCQ.TabIndex = 4;
            this.panelMCQ.Visible = false;
            // 
            // txtOption4
            // 
            this.txtOption4.Location = new System.Drawing.Point(69, 162);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(444, 22);
            this.txtOption4.TabIndex = 12;
            // 
            // txtOption3
            // 
            this.txtOption3.Location = new System.Drawing.Point(69, 117);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(444, 22);
            this.txtOption3.TabIndex = 11;
            // 
            // txtOption2
            // 
            this.txtOption2.Location = new System.Drawing.Point(72, 79);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(444, 22);
            this.txtOption2.TabIndex = 10;
            // 
            // txtOption1
            // 
            this.txtOption1.Location = new System.Drawing.Point(72, 39);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(444, 22);
            this.txtOption1.TabIndex = 9;
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.Location = new System.Drawing.Point(23, 163);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(44, 21);
            this.rbOption4.TabIndex = 4;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "D)";
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Location = new System.Drawing.Point(23, 117);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(43, 21);
            this.rbOption3.TabIndex = 3;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "C)";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Location = new System.Drawing.Point(23, 79);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(43, 21);
            this.rbOption2.TabIndex = 2;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "B)";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Location = new System.Drawing.Point(23, 39);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(43, 21);
            this.rbOption1.TabIndex = 1;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "A)";
            this.rbOption1.UseVisualStyleBackColor = true;
            this.rbOption1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Options";
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.txtCorrectAnswer);
            this.panelFill.Controls.Add(this.labelControl3);
            this.panelFill.Location = new System.Drawing.Point(478, 366);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(550, 204);
            this.panelFill.TabIndex = 5;
            this.panelFill.Visible = false;
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCorrectAnswer.Location = new System.Drawing.Point(67, 95);
            this.txtCorrectAnswer.Multiline = true;
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(411, 43);
            this.txtCorrectAnswer.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(183, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(178, 36);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Correct Answer";
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.labelControl4);
            this.panelCode.Controls.Add(this.txtExpectedAnswer);
            this.panelCode.Location = new System.Drawing.Point(478, 366);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(544, 573);
            this.panelCode.TabIndex = 5;
            this.panelCode.Visible = false;
            this.panelCode.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCode_Paint);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(188, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(156, 35);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Expected Code";
            // 
            // txtExpectedAnswer
            // 
            this.txtExpectedAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExpectedAnswer.Location = new System.Drawing.Point(3, 41);
            this.txtExpectedAnswer.Multiline = true;
            this.txtExpectedAnswer.Name = "txtExpectedAnswer";
            this.txtExpectedAnswer.Size = new System.Drawing.Size(538, 529);
            this.txtExpectedAnswer.TabIndex = 1;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddQuestion.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddQuestion.Appearance.Options.UseBackColor = true;
            this.btnAddQuestion.Appearance.Options.UseFont = true;
            this.btnAddQuestion.AppearanceHovered.BackColor = System.Drawing.Color.Lime;
            this.btnAddQuestion.AppearanceHovered.Options.UseBackColor = true;
            this.btnAddQuestion.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.btnAddQuestion.AppearancePressed.Options.UseBackColor = true;
            this.btnAddQuestion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAddQuestion.Location = new System.Drawing.Point(1136, 876);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(153, 60);
            this.btnAddQuestion.TabIndex = 6;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuestionText.Location = new System.Drawing.Point(478, 186);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(550, 156);
            this.txtQuestionText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(515, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose Question Style (mcq = multiple choice)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add Question";
            // 
            // ManageQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuestionText);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.panelCode);
            this.Controls.Add(this.panelMCQ);
            this.Controls.Add(this.cmbQuestionType);
            this.Controls.Add(this.lblExamTitle);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageQuestionsForm";
            this.Text = "ManageQuestionsForm";
            this.Load += new System.EventHandler(this.ManageQuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbQuestionType.Properties)).EndInit();
            this.panelMCQ.ResumeLayout(false);
            this.panelMCQ.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblExamTitle;
        private DevExpress.XtraEditors.ComboBoxEdit cmbQuestionType;
        private System.Windows.Forms.Panel panelMCQ;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panelCode;
        private DevExpress.XtraEditors.SimpleButton btnAddQuestion;
        private System.Windows.Forms.RadioButton rbOption1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtExpectedAnswer;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}