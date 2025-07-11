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
    public partial class ManageExamsForm : Form
    {
        private readonly int _teacherId;
        private List<Exam> _exams;
        private List<Question> _questions;
        private Exam _selectedExam;

        public event EventHandler<Exam> ManageQuestionsRequested;

        public ManageExamsForm(int teacherId)
        {
            InitializeComponent();
            _teacherId = teacherId;
            Text = "Manage Exams";

            // Load exams
            LoadExams();

            // Button click handlers
            btnAddQuestion.Click += btnAddQuestion_Click;
        }

        private void LoadExams()
        {
            _exams = ExamDAL.GetExamsByTeacher(_teacherId);
            CreateExamCards();
        }

        private void CreateExamCards()
        {
            flowLayoutExams.Controls.Clear();

            if (_exams == null || _exams.Count == 0)
            {
                // Show no exams message
                Label noExamsLabel = new Label
                {
                    Text = "You haven't created any exams yet.",
                    Font = new Font("Segoe UI", 14, FontStyle.Regular),
                    ForeColor = Color.FromArgb(128, 128, 128),
                    AutoSize = true,
                    Location = new Point(20, 20)
                };
                flowLayoutExams.Controls.Add(noExamsLabel);
                return;
            }

            // Sort exams by ID (most recent first)
            var sortedExams = _exams.OrderByDescending(e => e.Id).ToList();

            foreach (var exam in sortedExams)
            {
                Panel examCard = CreateExamCard(exam);
                flowLayoutExams.Controls.Add(examCard);
            }

            // Refresh cards to show proper selection state
            RefreshExamCards();
        }

        private Panel CreateExamCard(Exam exam)
        {
            Panel card = new Panel
            {
                Width = 620,
                Height = 160,
                Margin = new Padding(10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                Tag = exam // Store the exam object in the tag for easy access
            };

            // Add shadow and border effect
            card.Paint += (sender, e) =>
            {
                // Shadow
                using (var shadowBrush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                {
                    e.Graphics.FillRectangle(shadowBrush, 2, 2, card.Width - 4, card.Height - 4);
                }
                
                // Border - different color if selected
                Color borderColor = (_selectedExam != null && _selectedExam.Id == exam.Id) 
                    ? Color.FromArgb(128, 255, 128) 
                    : Color.FromArgb(240, 240, 240);
                
                using (var borderPen = new Pen(borderColor, 2))
                {
                    e.Graphics.DrawRectangle(borderPen, 0, 0, card.Width - 1, card.Height - 1);
                }
            };

            // Exam title
            Label titleLabel = new Label
            {
                Text = exam.Title,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(20, 15),
                AutoSize = true,
                MaximumSize = new Size(440, 0)
            };
            card.Controls.Add(titleLabel);

            // Exam date
            Label dateLabel = new Label
            {
                Text = $"Date: {exam.Date:MMM dd, yyyy}",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(128, 128, 128),
                Location = new Point(20, 45),
                AutoSize = true
            };
            card.Controls.Add(dateLabel);

            // Published status
            Label statusLabel = new Label
            {
                Text = exam.Published ? "✅ PUBLISHED" : "⏳ DRAFT",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = exam.Published ? Color.FromArgb(0, 128, 0) : Color.FromArgb(255, 165, 0),
                Location = new Point(20, 85),
                AutoSize = true
            };
            card.Controls.Add(statusLabel);

            // Selection indicator
            Label selectedLabel = new Label
            {
                Text = "✓ SELECTED",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 128, 0),
                Location = new Point(500, 15),
                AutoSize = true,
                Visible = false
            };
            card.Controls.Add(selectedLabel);

            // Publish/Unpublish button
            SimpleButton publishButton = new SimpleButton
            {
                Text = exam.Published ? "Unpublish" : "Publish",
                Size = new Size(120, 35),
                Location = new Point(20, 110),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            // Style the publish button with proper contrast
            if (exam.Published)
            {
                publishButton.Appearance.BackColor = Color.FromArgb(220, 53, 69);
                publishButton.Appearance.BorderColor = Color.FromArgb(220, 53, 69);
                publishButton.Appearance.ForeColor = Color.White;
                publishButton.AppearanceHovered.BackColor = Color.FromArgb(200, 35, 51);
                publishButton.AppearanceHovered.BorderColor = Color.FromArgb(200, 35, 51);
                publishButton.AppearanceHovered.ForeColor = Color.White;
            }
            else
            {
                publishButton.Appearance.BackColor = Color.FromArgb(40, 167, 69);
                publishButton.Appearance.BorderColor = Color.FromArgb(40, 167, 69);
                publishButton.Appearance.ForeColor = Color.White;
                publishButton.AppearanceHovered.BackColor = Color.FromArgb(30, 147, 59);
                publishButton.AppearanceHovered.BorderColor = Color.FromArgb(30, 147, 59);
                publishButton.AppearanceHovered.ForeColor = Color.White;
            }

            publishButton.Appearance.Options.UseBackColor = true;
            publishButton.Appearance.Options.UseBorderColor = true;
            publishButton.Appearance.Options.UseForeColor = true;
            publishButton.AppearanceHovered.Options.UseBackColor = true;
            publishButton.AppearanceHovered.Options.UseBorderColor = true;
            publishButton.AppearanceHovered.Options.UseForeColor = true;
            publishButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            publishButton.Click += (sender, e) => TogglePublishStatus(exam);
            card.Controls.Add(publishButton);
            
            // Make the entire card clickable
            card.Click += (sender, e) => SelectExam(exam);
            card.Cursor = Cursors.Hand;

            // Make all child controls also clickable (except publish button)
            foreach (Control control in card.Controls)
            {
                if (control != publishButton)
                {
                    control.Click += (sender, e) => SelectExam(exam);
                    control.Cursor = Cursors.Hand;
                }
            }

            // Add hover effect
            card.MouseEnter += (sender, e) =>
            {
                if (_selectedExam == null || _selectedExam.Id != exam.Id)
                {
                    card.BackColor = Color.FromArgb(250, 250, 250);
                }
            };
            card.MouseLeave += (sender, e) =>
            {
                if (_selectedExam == null || _selectedExam.Id != exam.Id)
                {
                    card.BackColor = Color.White;
                }
            };

            return card;
        }

        private void SelectExam(Exam exam)
        {
            _selectedExam = exam;
            LoadQuestions(exam);
            
            // Update questions title
            labelQuestionsTitle.Text = $"Questions - {exam.Title}";
            
            // Refresh all exam cards to update selection visual
            RefreshExamCards();
        }

        private void RefreshExamCards()
        {
            // Force repaint of all exam cards to update selection visual
            foreach (Control control in flowLayoutExams.Controls)
            {
                if (control is Panel card)
                {
                    card.Invalidate();
                    
                    // Update selection indicator
                    foreach (Control child in card.Controls)
                    {
                        if (child is Label label && label.Text == "✓ SELECTED")
                        {
                            label.Visible = (_selectedExam != null && card.Tag is Exam exam && exam.Id == _selectedExam.Id);
                        }
                    }
                }
            }
        }

        private void LoadQuestions(Exam exam)
        {
            _questions = QuestionDAL.GetQuestionsByExam(exam.Id);
            CreateQuestionCards();
        }

        private void CreateQuestionCards()
        {
            flowLayoutQuestions.Controls.Clear();

            if (_questions == null || _questions.Count == 0)
            {
                // Show no questions message
                Label noQuestionsLabel = new Label
                {
                    Text = "No questions added to this exam yet.",
                    Font = new Font("Segoe UI", 14, FontStyle.Regular),
                    ForeColor = Color.FromArgb(128, 128, 128),
                    AutoSize = true,
                    Location = new Point(20, 20)
                };
                flowLayoutQuestions.Controls.Add(noQuestionsLabel);
                return;
            }

            foreach (var question in _questions)
            {
                Panel questionCard = CreateQuestionCard(question);
                flowLayoutQuestions.Controls.Add(questionCard);
            }
        }

        private Panel CreateQuestionCard(Question question)
        {
            Panel card = new Panel
            {
                Width = 600,
                Height = 120,
                Margin = new Padding(10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            // Add shadow and border effect
            card.Paint += (sender, e) =>
            {
                // Shadow
                using (var shadowBrush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                {
                    e.Graphics.FillRectangle(shadowBrush, 2, 2, card.Width - 4, card.Height - 4);
                }
                
                // Border
                using (var borderPen = new Pen(Color.FromArgb(240, 240, 240), 1))
                {
                    e.Graphics.DrawRectangle(borderPen, 0, 0, card.Width - 1, card.Height - 1);
                }
            };

            // Question text (truncated if too long)
            string displayText = question.QuestionText.Length > 80 
                ? question.QuestionText.Substring(0, 80) + "..." 
                : question.QuestionText;

            Label questionLabel = new Label
            {
                Text = displayText,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(20, 15),
                AutoSize = true,
                MaximumSize = new Size(400, 0)
            };
            card.Controls.Add(questionLabel);

            // Question type
            Label typeLabel = new Label
            {
                Text = $"Type: {question.QuestionType.ToUpper()}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(128, 128, 128),
                Location = new Point(20, 45),
                AutoSize = true
            };
            card.Controls.Add(typeLabel);

            // Delete button - moved to the left side
            SimpleButton deleteButton = new SimpleButton
            {
                Text = "Delete",
                Size = new Size(100, 30),
                Location = new Point(20, 70),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            // Style the delete button
            deleteButton.Appearance.BackColor = Color.FromArgb(255, 128, 128);
            deleteButton.Appearance.BorderColor = Color.FromArgb(255, 128, 128);
            deleteButton.Appearance.ForeColor = Color.White;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.Appearance.Options.UseBorderColor = true;
            deleteButton.Appearance.Options.UseForeColor = true;
            deleteButton.AppearanceHovered.BackColor = Color.FromArgb(220, 53, 69);
            deleteButton.AppearanceHovered.BorderColor = Color.FromArgb(220, 53, 69);
            deleteButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            deleteButton.Click += (sender, e) => DeleteQuestion(question);
            card.Controls.Add(deleteButton);

            // Make the card clickable to show question details
            card.Click += (sender, e) => ShowQuestionDetails(question);
            card.Cursor = Cursors.Hand;

            // Make all child controls also clickable (except delete button)
            foreach (Control control in card.Controls)
            {
                if (control != deleteButton)
                {
                    control.Click += (sender, e) => ShowQuestionDetails(question);
                    control.Cursor = Cursors.Hand;
                }
            }

            // Add hover effect
            card.MouseEnter += (sender, e) =>
            {
                card.BackColor = Color.FromArgb(250, 250, 250);
            };
            card.MouseLeave += (sender, e) =>
            {
                card.BackColor = Color.White;
            };

            return card;
        }

        private void ShowQuestionDetails(Question question)
        {
            // Get options for MCQ questions
            var options = new List<Option>();
            if (question.QuestionType.ToLower() == "mcq")
            {
                options = OptionDAL.GetOptionsByQuestion(question.Id);
            }

            // Create detailed message
            string details = $"📝 Question Details\n" +
                           $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n" +
                           $"📋 Question: {question.QuestionText}\n\n" +
                           $"📊 Type: {question.QuestionType.ToUpper()}\n" +
                           $"🆔 Question ID: {question.Id}\n\n";

            if (question.QuestionType.ToLower() == "mcq" && options.Count > 0)
            {
                details += $"📋 Options:\n";
                foreach (var option in options)
                {
                    string correctIndicator = option.IsCorrect ? " ✓" : "";
                    details += $"   • {option.OptionText}{correctIndicator}\n";
                }
                details += "\n";
            }
            else if (question.QuestionType.ToLower() == "fill")
            {
                details += $"✅ Correct Answer: {question.CorrectAnswer}\n\n";
            }
            else if (question.QuestionType.ToLower() == "code")
            {
                details += $"💻 Code Question - Manual evaluation required\n\n";
            }

            details += $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n" +
                      $"💡 Tip: Click anywhere on the question card to view details";

            // Show popup with question details
            MessageBox.Show(details, "📋 Question Details", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteQuestion(Question question)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete this question?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            // Delete options first
            OptionDAL.DeleteOptionsByQuestion(question.Id);
            // Delete question
            QuestionDAL.DeleteQuestion(question.Id);

            // Reload questions
            if (_selectedExam != null)
            {
                LoadQuestions(_selectedExam);
            }
        }

        private void ManageExamsForm_Load(object sender, EventArgs e)
        {
            // Form is already loaded with exams
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (_selectedExam == null)
            {
                MessageBox.Show("Please select an exam first.", "No Exam Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Reuse existing ManageQuestionsForm to add questions
            ManageQuestionsRequested?.Invoke(this, _selectedExam);
            
            // Reload questions after adding
            LoadQuestions(_selectedExam);
        }

        private void TogglePublishStatus(Exam exam)
        {
            string action = exam.Published ? "unpublish" : "publish";
            string message = exam.Published 
                ? $"Are you sure you want to unpublish '{exam.Title}'? Students will no longer be able to see this exam."
                : $"Are you sure you want to publish '{exam.Title}'? Students will be able to take this exam.";

            var result = MessageBox.Show(message, $"Confirm {action}", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool newStatus = !exam.Published;
                if (ExamDAL.UpdateExamPublished(exam.Id, newStatus))
                {
                    exam.Published = newStatus;
                    MessageBox.Show($"Exam '{exam.Title}' has been {(newStatus ? "published" : "unpublished")} successfully!", 
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Refresh the exam cards to show updated status
                    CreateExamCards();
                }
                else
                {
                    MessageBox.Show("Failed to update exam status. Please try again.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
