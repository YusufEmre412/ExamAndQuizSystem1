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
using DevExpress.XtraEditors;

namespace ExamAndQuizSystem.Forms
{
    public partial class CreateExamForm : Form
    {
        public event EventHandler<Exam> ExamCreated;

        private readonly int _teacherId;
        public CreateExamForm(int teacherId)
        {
            InitializeComponent();
            _teacherId = teacherId;
            dateEditDate.DateTime = DateTime.Today;
        }

        private void CreateExamForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text.Trim();
            var date = dateEditDate.DateTime;

            if (string.IsNullOrEmpty(title))
            {
                XtraMessageBox.Show("Please enter an exam title.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Exam = new Exam
            {
                Title = title,
                TeacherId = _teacherId,
                Date = date,
                Published = false // New exams are created as drafts by default
            };

            if (ExamDAL.AddExam(Exam))
            {
                DialogResult = DialogResult.OK;
                Close();
            }

            else
            {
                XtraMessageBox.Show("Failed to save exam!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
