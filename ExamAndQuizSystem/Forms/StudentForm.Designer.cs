namespace ExamAndQuizSystem.Forms
{
    partial class StudentForm
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
            this.gridExams = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTakeExam = new DevExpress.XtraEditors.SimpleButton();
            this.btnMyGrades = new DevExpress.XtraEditors.SimpleButton();
            this.btnMessages = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelExams = new System.Windows.Forms.FlowLayoutPanel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelExamsTitle = new System.Windows.Forms.Label();
            this.btnTakeExam2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridExams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelExams.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridExams
            // 
            this.gridExams.Location = new System.Drawing.Point(20, 100);
            this.gridExams.MainView = this.gridView1;
            this.gridExams.Name = "gridExams";
            this.gridExams.Size = new System.Drawing.Size(1420, 920);
            this.gridExams.TabIndex = 0;
            this.gridExams.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTakeExam.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTakeExam.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakeExam.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTakeExam.Appearance.Options.UseBackColor = true;
            this.btnTakeExam.Appearance.Options.UseBorderColor = true;
            this.btnTakeExam.Appearance.Options.UseFont = true;
            this.btnTakeExam.Appearance.Options.UseForeColor = true;
            this.btnTakeExam.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakeExam.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakeExam.AppearanceHovered.Options.UseBackColor = true;
            this.btnTakeExam.AppearanceHovered.Options.UseBorderColor = true;
            this.btnTakeExam.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTakeExam.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTakeExam.AppearancePressed.Options.UseBackColor = true;
            this.btnTakeExam.AppearancePressed.Options.UseBorderColor = true;
            this.btnTakeExam.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnTakeExam.ImageOptions.Image = global::ExamAndQuizSystem.Properties.Resources.icons8_pencil_drawing_50;
            this.btnTakeExam.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTakeExam.Location = new System.Drawing.Point(12, 333);
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.Size = new System.Drawing.Size(280, 60);
            this.btnTakeExam.TabIndex = 1;
            this.btnTakeExam.Text = "Take Exam";
            this.btnTakeExam.Click += new System.EventHandler(this.btnTakeExam_Click);
            // 
            // btnMyGrades
            // 
            this.btnMyGrades.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMyGrades.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnMyGrades.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMyGrades.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMyGrades.Appearance.Options.UseBackColor = true;
            this.btnMyGrades.Appearance.Options.UseBorderColor = true;
            this.btnMyGrades.Appearance.Options.UseFont = true;
            this.btnMyGrades.Appearance.Options.UseForeColor = true;
            this.btnMyGrades.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnMyGrades.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnMyGrades.AppearanceHovered.Options.UseBackColor = true;
            this.btnMyGrades.AppearanceHovered.Options.UseBorderColor = true;
            this.btnMyGrades.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnMyGrades.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnMyGrades.AppearancePressed.Options.UseBackColor = true;
            this.btnMyGrades.AppearancePressed.Options.UseBorderColor = true;
            this.btnMyGrades.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnMyGrades.ImageOptions.Image = global::ExamAndQuizSystem.Properties.Resources.icons8_exam_50;
            this.btnMyGrades.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMyGrades.Location = new System.Drawing.Point(12, 253);
            this.btnMyGrades.Name = "btnMyGrades";
            this.btnMyGrades.Size = new System.Drawing.Size(280, 60);
            this.btnMyGrades.TabIndex = 2;
            this.btnMyGrades.Text = "My Grades";
            this.btnMyGrades.Click += new System.EventHandler(this.btnMyGrades_Click);
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
            this.btnMessages.Location = new System.Drawing.Point(12, 413);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(280, 60);
            this.btnMessages.TabIndex = 4;
            this.btnMessages.Text = "Messages";
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnMessages);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTakeExam);
            this.panel1.Controls.Add(this.btnMyGrades);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 1033);
            this.panel1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.simpleButton1.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.simpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.ImageOptions.Image = global::ExamAndQuizSystem.Properties.Resources.icons8_log_out_50;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(12, 493);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(280, 60);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Log Out";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExamAndQuizSystem.Properties.Resources._81204_books_512x512;
            this.pictureBox2.Location = new System.Drawing.Point(156, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 124);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamAndQuizSystem.Properties.Resources._34630_man_400x400;
            this.pictureBox1.Location = new System.Drawing.Point(12, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.panelExams);
            this.panel2.Controls.Add(this.labelExamsTitle);
            this.panel2.Controls.Add(this.btnTakeExam2);
            this.panel2.Controls.Add(this.gridExams);
            this.panel2.Location = new System.Drawing.Point(326, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1574, 1033);
            this.panel2.TabIndex = 4;
            // 
            // panelExams
            // 
            this.panelExams.AutoScroll = true;
            this.panelExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelExams.Controls.Add(this.labelWelcome);
            this.panelExams.Controls.Add(this.labelSubtitle);
            this.panelExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExams.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelExams.Location = new System.Drawing.Point(0, 0);
            this.panelExams.Name = "panelExams";
            this.panelExams.Padding = new System.Windows.Forms.Padding(20);
            this.panelExams.Size = new System.Drawing.Size(1574, 1033);
            this.panelExams.TabIndex = 6;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelWelcome.Location = new System.Drawing.Point(23, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(309, 54);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Welcome back!";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelSubtitle.Location = new System.Drawing.Point(23, 74);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(356, 32);
            this.labelSubtitle.TabIndex = 5;
            this.labelSubtitle.Text = "Manage your exams and grades";
            // 
            // labelExamsTitle
            // 
            this.labelExamsTitle.AutoSize = true;
            this.labelExamsTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelExamsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelExamsTitle.Location = new System.Drawing.Point(30, 20);
            this.labelExamsTitle.Name = "labelExamsTitle";
            this.labelExamsTitle.Size = new System.Drawing.Size(275, 46);
            this.labelExamsTitle.TabIndex = 7;
            this.labelExamsTitle.Text = "Available Exams";
            // 
            // btnTakeExam2
            // 
            this.btnTakeExam2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTakeExam2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTakeExam2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakeExam2.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTakeExam2.Appearance.Options.UseBackColor = true;
            this.btnTakeExam2.Appearance.Options.UseBorderColor = true;
            this.btnTakeExam2.Appearance.Options.UseFont = true;
            this.btnTakeExam2.Appearance.Options.UseForeColor = true;
            this.btnTakeExam2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakeExam2.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTakeExam2.AppearanceHovered.Options.UseBackColor = true;
            this.btnTakeExam2.AppearanceHovered.Options.UseBorderColor = true;
            this.btnTakeExam2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnTakeExam2.Location = new System.Drawing.Point(1340, 20);
            this.btnTakeExam2.Name = "btnTakeExam2";
            this.btnTakeExam2.Size = new System.Drawing.Size(100, 40);
            this.btnTakeExam2.TabIndex = 1;
            this.btnTakeExam2.Text = "Start Exam";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.Text = "Student Dashboard";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridExams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelExams.ResumeLayout(false);
            this.panelExams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridExams;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnTakeExam;
        private DevExpress.XtraEditors.SimpleButton btnMyGrades;
        private DevExpress.XtraEditors.SimpleButton btnMessages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnTakeExam2;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.FlowLayoutPanel panelExams;
        private System.Windows.Forms.Label labelExamsTitle;
    }
}