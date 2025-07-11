namespace ExamAndQuizSystem.Forms
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.btnNewExam = new DevExpress.XtraEditors.SimpleButton();
            this.btnManageQuestions = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnLogOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnMessages = new DevExpress.XtraEditors.SimpleButton();
            this.btnManageResults = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridExams = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewExam
            // 
            this.btnNewExam.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewExam.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewExam.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewExam.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNewExam.Appearance.Options.UseBackColor = true;
            this.btnNewExam.Appearance.Options.UseBorderColor = true;
            this.btnNewExam.Appearance.Options.UseFont = true;
            this.btnNewExam.Appearance.Options.UseForeColor = true;
            this.btnNewExam.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewExam.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewExam.AppearanceHovered.Options.UseBackColor = true;
            this.btnNewExam.AppearanceHovered.Options.UseBorderColor = true;
            this.btnNewExam.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewExam.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewExam.AppearancePressed.Options.UseBackColor = true;
            this.btnNewExam.AppearancePressed.Options.UseBorderColor = true;
            this.btnNewExam.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnNewExam.ImageOptions.Image = global::ExamAndQuizSystem.Properties.Resources.icons8_plus_50;
            this.btnNewExam.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewExam.Location = new System.Drawing.Point(20, 350);
            this.btnNewExam.Name = "btnNewExam";
            this.btnNewExam.Size = new System.Drawing.Size(280, 60);
            this.btnNewExam.TabIndex = 0;
            this.btnNewExam.Text = "Create New Exam";
            this.btnNewExam.Click += new System.EventHandler(this.btnNewExam_Click);
            // 
            // btnManageQuestions
            // 
            this.btnManageQuestions.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnManageQuestions.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnManageQuestions.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManageQuestions.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageQuestions.Appearance.Options.UseBackColor = true;
            this.btnManageQuestions.Appearance.Options.UseBorderColor = true;
            this.btnManageQuestions.Appearance.Options.UseFont = true;
            this.btnManageQuestions.Appearance.Options.UseForeColor = true;
            this.btnManageQuestions.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnManageQuestions.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnManageQuestions.AppearanceHovered.Options.UseBackColor = true;
            this.btnManageQuestions.AppearanceHovered.Options.UseBorderColor = true;
            this.btnManageQuestions.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnManageQuestions.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnManageQuestions.AppearancePressed.Options.UseBackColor = true;
            this.btnManageQuestions.AppearancePressed.Options.UseBorderColor = true;
            this.btnManageQuestions.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnManageQuestions.ImageOptions.Image = global::ExamAndQuizSystem.Properties.Resources.icons8_exam_50;
            this.btnManageQuestions.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnManageQuestions.Location = new System.Drawing.Point(20, 510);
            this.btnManageQuestions.Name = "btnManageQuestions";
            this.btnManageQuestions.Size = new System.Drawing.Size(280, 60);
            this.btnManageQuestions.TabIndex = 2;
            this.btnManageQuestions.Text = "Manage Exams";
            this.btnManageQuestions.Click += new System.EventHandler(this.btnManageQuestions_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelSubtitle);
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnMessages);
            this.panel1.Controls.Add(this.btnManageResults);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnManageQuestions);
            this.panel1.Controls.Add(this.btnNewExam);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 1035);
            this.panel1.TabIndex = 3;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.labelSubtitle.Location = new System.Drawing.Point(60, 270);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(262, 23);
            this.labelSubtitle.TabIndex = 6;
            this.labelSubtitle.Text = "Manage your exams and content";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelWelcome.Location = new System.Drawing.Point(80, 240);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(145, 28);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome back!";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogOut.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogOut.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Appearance.Options.UseBackColor = true;
            this.btnLogOut.Appearance.Options.UseBorderColor = true;
            this.btnLogOut.Appearance.Options.UseFont = true;
            this.btnLogOut.Appearance.Options.UseForeColor = true;
            this.btnLogOut.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnLogOut.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnLogOut.AppearanceHovered.Options.UseBackColor = true;
            this.btnLogOut.AppearanceHovered.Options.UseBorderColor = true;
            this.btnLogOut.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.btnLogOut.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.btnLogOut.AppearancePressed.Options.UseBackColor = true;
            this.btnLogOut.AppearancePressed.Options.UseBorderColor = true;
            this.btnLogOut.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLogOut.ImageOptions.Image = global::ExamAndQuizSystem.Properties.Resources.icons8_log_out_50;
            this.btnLogOut.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLogOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogOut.Location = new System.Drawing.Point(20, 670);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(280, 60);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnMessages.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnMessages.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMessages.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnMessages.Appearance.Options.UseBackColor = true;
            this.btnMessages.Appearance.Options.UseBorderColor = true;
            this.btnMessages.Appearance.Options.UseFont = true;
            this.btnMessages.Appearance.Options.UseForeColor = true;
            this.btnMessages.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(160)))));
            this.btnMessages.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(160)))));
            this.btnMessages.AppearanceHovered.Options.UseBackColor = true;
            this.btnMessages.AppearanceHovered.Options.UseBorderColor = true;
            this.btnMessages.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnMessages.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnMessages.AppearancePressed.Options.UseBackColor = true;
            this.btnMessages.AppearancePressed.Options.UseBorderColor = true;
            this.btnMessages.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnMessages.ImageOptions.Image = global::ExamAndQuizSystem.Properties.Resources.icons8_mail_50;
            this.btnMessages.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMessages.Location = new System.Drawing.Point(20, 430);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(280, 60);
            this.btnMessages.TabIndex = 5;
            this.btnMessages.Text = "Messages";
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnManageResults
            // 
            this.btnManageResults.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnManageResults.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnManageResults.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManageResults.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManageResults.Appearance.Options.UseBackColor = true;
            this.btnManageResults.Appearance.Options.UseBorderColor = true;
            this.btnManageResults.Appearance.Options.UseFont = true;
            this.btnManageResults.Appearance.Options.UseForeColor = true;
            this.btnManageResults.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnManageResults.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnManageResults.AppearanceHovered.Options.UseBackColor = true;
            this.btnManageResults.AppearanceHovered.Options.UseBorderColor = true;
            this.btnManageResults.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnManageResults.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnManageResults.AppearancePressed.Options.UseBackColor = true;
            this.btnManageResults.AppearancePressed.Options.UseBorderColor = true;
            this.btnManageResults.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnManageResults.ImageOptions.Image = global::ExamAndQuizSystem.Properties.Resources._13;
            this.btnManageResults.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnManageResults.Location = new System.Drawing.Point(20, 590);
            this.btnManageResults.Name = "btnManageResults";
            this.btnManageResults.Size = new System.Drawing.Size(280, 60);
            this.btnManageResults.TabIndex = 3;
            this.btnManageResults.Text = "Manage Results";
            this.btnManageResults.Click += new System.EventHandler(this.btnManageResults_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teacher";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.gridExams);
            this.panel2.Location = new System.Drawing.Point(326, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1580, 1032);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 1035);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gridExams
            // 
            this.gridExams.Location = new System.Drawing.Point(955, 222);
            this.gridExams.MainView = this.gridView1;
            this.gridExams.Name = "gridExams";
            this.gridExams.Size = new System.Drawing.Size(533, 483);
            this.gridExams.TabIndex = 1;
            this.gridExams.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridExams.Visible = false;
            this.gridExams.Click += new System.EventHandler(this.gridExams_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridExams;
            this.gridView1.Name = "gridView1";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1908, 1035);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherForm";
            this.Text = "Teacher Dashboard";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNewExam;
        private DevExpress.XtraEditors.SimpleButton btnManageQuestions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridExams;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnManageResults;
        private DevExpress.XtraEditors.SimpleButton btnMessages;
        private DevExpress.XtraEditors.SimpleButton btnLogOut;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelSubtitle;
    }
}