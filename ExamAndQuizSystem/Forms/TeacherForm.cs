using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamAndQuizSystem.DataAccess;
using ExamAndQuizSystem.Models;
using DevExpress.XtraGrid.Views.Grid;

namespace ExamAndQuizSystem.Forms
{
    public partial class TeacherForm : Form
    {
        
        private readonly Users _currentUser;

        public TeacherForm(Users user)
        {
            InitializeComponent();
            _currentUser = user;
            this.Text = $"Teacher Panel - {_currentUser.FullName}";
            LoadExams();
        }

        private void LoadExams()
        {
            List<Exam> exams = ExamDAL.GetExamsByTeacher(_currentUser.Id);
            gridExams.DataSource = exams;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnNewExam_Click(object sender, EventArgs e)
        {
            ShowCreateExam();
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            ShowManageExams();
        }
        private void ShowCreateExam()
        {
            panel2.Controls.Clear();

            var createForm = new CreateExamForm(_currentUser.Id)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            // Sınav kaydedildiğinde otomatik olarak soruları ekleme ekranına geç
            createForm.ExamCreated += (s, exam) => ShowManageQuestions(exam);

            panel2.Controls.Add(createForm);
            createForm.Show();
        }
        private void ShowManageExams()
        {
            panel2.Controls.Clear();

            var manageExams = new ManageExamsForm(_currentUser.Id)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            // Eğer ManageExamsForm içinde bir "EditQuestions" event'i tetikleniyorsa:
            // manageExams.EditQuestionsClicked += (s, exam) => ShowManageQuestions(exam);
            manageExams.ManageQuestionsRequested += (s, exam) => ShowManageQuestions(exam);
            panel2.Controls.Add(manageExams);
            manageExams.Show();
        }
        private void ShowManageQuestions(Exam exam)
        {
            panel2.Controls.Clear();

            var manageQuestions = new ManageQuestionsForm(exam)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panel2.Controls.Add(manageQuestions);
            manageQuestions.Show();
        }

        private void gridExams_Click(object sender, EventArgs e)
        {

        }

        private void btnManageResults_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var frm = new ManageResultsForm(_currentUser)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var messagingForm = new MessagingForm(_currentUser)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(messagingForm);
            messagingForm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Close this form and open login form again.
            this.Hide();

            using (var login = new LoginForm())
            {
                login.ShowDialog();
            }

            this.Close();
        }
    }
}
