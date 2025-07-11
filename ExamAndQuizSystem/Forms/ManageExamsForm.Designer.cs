namespace ExamAndQuizSystem.Forms
{
    partial class ManageExamsForm
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
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.flowLayoutQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.panelQuestionsHeader = new System.Windows.Forms.Panel();
            this.btnAddQuestion = new DevExpress.XtraEditors.SimpleButton();
            this.labelQuestionsTitle = new System.Windows.Forms.Label();
            this.panelExams = new System.Windows.Forms.Panel();
            this.flowLayoutExams = new System.Windows.Forms.FlowLayoutPanel();
            this.panelExamsHeader = new System.Windows.Forms.Panel();
            this.labelExamsTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelQuestions.SuspendLayout();
            this.panelQuestionsHeader.SuspendLayout();
            this.panelExams.SuspendLayout();
            this.panelExamsHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelMain.Controls.Add(this.panelQuestions);
            this.panelMain.Controls.Add(this.panelExams);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1325, 736);
            this.panelMain.TabIndex = 0;
            // 
            // panelQuestions
            // 
            this.panelQuestions.BackColor = System.Drawing.Color.White;
            this.panelQuestions.Controls.Add(this.flowLayoutQuestions);
            this.panelQuestions.Controls.Add(this.panelQuestionsHeader);
            this.panelQuestions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelQuestions.Location = new System.Drawing.Point(650, 0);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(675, 736);
            this.panelQuestions.TabIndex = 1;
            // 
            // flowLayoutQuestions
            // 
            this.flowLayoutQuestions.AutoScroll = true;
            this.flowLayoutQuestions.BackColor = System.Drawing.Color.White;
            this.flowLayoutQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutQuestions.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutQuestions.Name = "flowLayoutQuestions";
            this.flowLayoutQuestions.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutQuestions.Size = new System.Drawing.Size(675, 656);
            this.flowLayoutQuestions.TabIndex = 1;
            this.flowLayoutQuestions.WrapContents = false;
            // 
            // panelQuestionsHeader
            // 
            this.panelQuestionsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.panelQuestionsHeader.Controls.Add(this.btnAddQuestion);
            this.panelQuestionsHeader.Controls.Add(this.labelQuestionsTitle);
            this.panelQuestionsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestionsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelQuestionsHeader.Name = "panelQuestionsHeader";
            this.panelQuestionsHeader.Size = new System.Drawing.Size(675, 80);
            this.panelQuestionsHeader.TabIndex = 2;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddQuestion.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddQuestion.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddQuestion.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestion.Appearance.Options.UseBackColor = true;
            this.btnAddQuestion.Appearance.Options.UseBorderColor = true;
            this.btnAddQuestion.Appearance.Options.UseFont = true;
            this.btnAddQuestion.Appearance.Options.UseForeColor = true;
            this.btnAddQuestion.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddQuestion.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddQuestion.AppearanceHovered.Options.UseBackColor = true;
            this.btnAddQuestion.AppearanceHovered.Options.UseBorderColor = true;
            this.btnAddQuestion.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnAddQuestion.Location = new System.Drawing.Point(479, 22);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(150, 40);
            this.btnAddQuestion.TabIndex = 1;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // labelQuestionsTitle
            // 
            this.labelQuestionsTitle.AutoSize = true;
            this.labelQuestionsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelQuestionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelQuestionsTitle.Location = new System.Drawing.Point(20, 20);
            this.labelQuestionsTitle.Name = "labelQuestionsTitle";
            this.labelQuestionsTitle.Size = new System.Drawing.Size(144, 37);
            this.labelQuestionsTitle.TabIndex = 3;
            this.labelQuestionsTitle.Text = "Questions";
            // 
            // panelExams
            // 
            this.panelExams.BackColor = System.Drawing.Color.White;
            this.panelExams.Controls.Add(this.flowLayoutExams);
            this.panelExams.Controls.Add(this.panelExamsHeader);
            this.panelExams.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelExams.Location = new System.Drawing.Point(0, 0);
            this.panelExams.Name = "panelExams";
            this.panelExams.Size = new System.Drawing.Size(650, 736);
            this.panelExams.TabIndex = 0;
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
            this.flowLayoutExams.Size = new System.Drawing.Size(650, 656);
            this.flowLayoutExams.TabIndex = 0;
            this.flowLayoutExams.WrapContents = false;
            // 
            // panelExamsHeader
            // 
            this.panelExamsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.panelExamsHeader.Controls.Add(this.labelExamsTitle);
            this.panelExamsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExamsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelExamsHeader.Name = "panelExamsHeader";
            this.panelExamsHeader.Size = new System.Drawing.Size(650, 80);
            this.panelExamsHeader.TabIndex = 1;
            // 
            // labelExamsTitle
            // 
            this.labelExamsTitle.AutoSize = true;
            this.labelExamsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelExamsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelExamsTitle.Location = new System.Drawing.Point(20, 20);
            this.labelExamsTitle.Name = "labelExamsTitle";
            this.labelExamsTitle.Size = new System.Drawing.Size(146, 37);
            this.labelExamsTitle.TabIndex = 0;
            this.labelExamsTitle.Text = "My Exams";
            // 
            // ManageExamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 736);
            this.Controls.Add(this.panelMain);
            this.Name = "ManageExamsForm";
            this.Text = "Manage Exams";
            this.Load += new System.EventHandler(this.ManageExamsForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelQuestions.ResumeLayout(false);
            this.panelQuestionsHeader.ResumeLayout(false);
            this.panelQuestionsHeader.PerformLayout();
            this.panelExams.ResumeLayout(false);
            this.panelExamsHeader.ResumeLayout(false);
            this.panelExamsHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Panel panelQuestionsHeader;
        private DevExpress.XtraEditors.SimpleButton btnAddQuestion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutQuestions;
        private System.Windows.Forms.Panel panelExams;
        private System.Windows.Forms.Panel panelExamsHeader;
        private System.Windows.Forms.Label labelExamsTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutExams;
        private System.Windows.Forms.Label labelQuestionsTitle;
    }
}