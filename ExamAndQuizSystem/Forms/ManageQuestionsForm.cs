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

namespace ExamAndQuizSystem.Forms
{
    public partial class ManageQuestionsForm : Form
    {
        private readonly Exam _exam;
        public ManageQuestionsForm(Exam exam)
        {
            InitializeComponent();
            _exam = exam;
            lblExamTitle.Text = $"Exam: {exam.Title} (ID: {exam.Id})";

            // Tüm alt panelleri gizle
            panelMCQ.Visible = false;
            panelFill.Visible = false;
            panelCode.Visible = false;

            // ComboBox öğelerini ekle

            cmbQuestionType.SelectedIndex = -1; // Başlangıçta seçili olmasın
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            // 1. Ortak alanları al
            string qText = txtQuestionText.Text.Trim();
            string qType = cmbQuestionType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(qType))
            {
                MessageBox.Show("Please select a question type.",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(qText))
            {
                MessageBox.Show("Please enter question text.",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Question nesnesini oluştur
            var question = new Question
            {
                ExamId = _exam.Id,
                QuestionText = qText,
                QuestionType = qType,
                CorrectAnswer = null  // MCQ hariç dolduracağız
            };

            // 3. Tip bazlı işlem
            if (qType == "mcq")
            {
                // 3.1. MCQ: Her bir seçeneği ve doğru şıkkı al
                var options = new List<Option>();

                // Option 1
                if (!string.IsNullOrEmpty(txtOption1.Text.Trim()))
                {
                    options.Add(new Option
                    {
                        OptionText = txtOption1.Text.Trim(),
                        IsCorrect = rbOption1.Checked
                    });
                }
                // Option 2
                if (!string.IsNullOrEmpty(txtOption2.Text.Trim()))
                {
                    options.Add(new Option
                    {
                        OptionText = txtOption2.Text.Trim(),
                        IsCorrect = rbOption2.Checked
                    });
                }
                // Option 3
                if (!string.IsNullOrEmpty(txtOption3.Text.Trim()))
                {
                    options.Add(new Option
                    {
                        OptionText = txtOption3.Text.Trim(),
                        IsCorrect = rbOption3.Checked
                    });
                }
                // Option 4
                if (!string.IsNullOrEmpty(txtOption4.Text.Trim()))
                {
                    options.Add(new Option
                    {
                        OptionText = txtOption4.Text.Trim(),
                        IsCorrect = rbOption4.Checked
                    });
                }

                if (options.Count < 2)
                {
                    MessageBox.Show("Please enter at least 2 options.",
                                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!options.Exists(o => o.IsCorrect))
                {
                    MessageBox.Show("Please select the correct option.",
                                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3.1.1. Soru ekle, ID’yi al
                int questionId = QuestionDAL.AddQuestion(question);
                if (questionId < 0)
                {
                    MessageBox.Show("Failed to add question.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3.1.2. Her bir seçeneği OptionDAL ile kaydet
                bool allOk = true;
                foreach (var opt in options)
                {
                    opt.QuestionId = questionId;
                    if (!OptionDAL.AddOption(opt))
                    {
                        allOk = false;
                        break;
                    }
                }
                if (!allOk)
                {
                    MessageBox.Show("Question added but failed to save one or more options.",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("MCQ question added successfully!",
                                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (qType == "fill")
            {
                // 3.2. Fill-in-the-blank: txtCorrectAnswer.Text
                string correct = txtCorrectAnswer.Text.Trim();
                if (string.IsNullOrEmpty(correct))
                {
                    MessageBox.Show("Please enter the correct answer for fill-in-the-blank.",
                                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                question.CorrectAnswer = correct;

                int questionId = QuestionDAL.AddQuestion(question);
                if (questionId < 0)
                {
                    MessageBox.Show("Failed to add question.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Fill-in-the-blank question added successfully!",
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (qType == "code")
            {
                // 3.3. Code: txtExpectedAnswer.Text
                question.CorrectAnswer = txtExpectedAnswer.Text.Trim() ?? "";

                int questionId = QuestionDAL.AddQuestion(question);
                if (questionId < 0)
                {
                    MessageBox.Show("Failed to add question.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Code question added successfully!",
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unknown question type.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Soru eklendikten sonra UI’i temizle / yeni soru eklemek istersen gerekli alanları resetle
            txtQuestionText.Clear();
            cmbQuestionType.SelectedIndex = -1;
            panelMCQ.Visible = false;
            panelFill.Visible = false;
            panelCode.Visible = false;
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            rbOption1.Checked = rbOption2.Checked = rbOption3.Checked = rbOption4.Checked = false;
            txtCorrectAnswer.Clear();
            txtExpectedAnswer.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelCode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCorrectAnswer_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ManageQuestionsForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void cmbQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbQuestionType.SelectedItem?.ToString();
            // Hide All panels

            panelMCQ.Visible = false;
            panelFill.Visible = false;
            panelCode.Visible = false;

            if (selected == "mcq")
                panelMCQ.Visible = true;
            else if (selected == "fill")
                panelFill.Visible = true;
            else if (selected == "code")
                panelCode.Visible = true;
        }
    }
}
