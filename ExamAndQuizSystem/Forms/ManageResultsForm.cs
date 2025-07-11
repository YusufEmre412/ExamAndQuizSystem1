using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ExamAndQuizSystem.Models;
using ExamAndQuizSystem.DataAccess;

namespace ExamAndQuizSystem.Forms
{
    public partial class ManageResultsForm : Form
    {
        private readonly Users _teacher;
        private List<Exam> _exams;
        private List<ResultItem> _results;
        private Exam _selectedExam;

        public ManageResultsForm(Users teacher)
        {
            InitializeComponent();
            _teacher = teacher;
            Text = "Manage Results";

            // Load exams
            LoadExams();
        }

        private void LoadExams()
        {
            _exams = ExamDAL.GetExamsByTeacher(_teacher.Id);
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
                Width = 570,
                Height = 100,
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
                MaximumSize = new Size(400, 0)
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

            // Selection indicator
            Label selectedLabel = new Label
            {
                Text = "✓ SELECTED",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 128, 0),
                Location = new Point(450, 15),
                AutoSize = true,
                Visible = false
            };
            card.Controls.Add(selectedLabel);

            // Make the entire card clickable
            card.Click += (sender, e) => SelectExam(exam);
            card.Cursor = Cursors.Hand;

            // Make all child controls also clickable
            foreach (Control control in card.Controls)
            {
                control.Click += (sender, e) => SelectExam(exam);
                control.Cursor = Cursors.Hand;
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
            LoadResults(exam);
            
            // Update results title
            labelResultsTitle.Text = $"Results - {exam.Title}";
            
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

        private void LoadResults(Exam exam)
        {
            // We need a projection combining Result + Student name
            _results = ResultDAL.GetResultsByExam(exam.Id)
                .Select(r => new ResultItem
                {
                    Id = r.Id,
                    ExamId = r.ExamId,
                    StudentId = r.StudentId,
                    StudentName = UserDAL.GetById(r.StudentId)?.FullName ?? "Unknown Student",
                    Score = r.Score,
                    TakenDate = r.TakenDate
                }).ToList();

            CreateResultCards();
        }

        private void CreateResultCards()
        {
            flowLayoutResults.Controls.Clear();

            if (_results == null || _results.Count == 0)
            {
                // Show no results message
                Label noResultsLabel = new Label
                {
                    Text = "No students have taken this exam yet.",
                    Font = new Font("Segoe UI", 14, FontStyle.Regular),
                    ForeColor = Color.FromArgb(128, 128, 128),
                    AutoSize = true,
                    Location = new Point(20, 20)
                };
                flowLayoutResults.Controls.Add(noResultsLabel);
                return;
            }

            foreach (var result in _results)
            {
                Panel resultCard = CreateResultCard(result);
                flowLayoutResults.Controls.Add(resultCard);
            }
        }

        private Panel CreateResultCard(ResultItem result)
        {
            Panel card = new Panel
            {
                Width = 600,
                Height = 150,
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

            // Student name
            Label nameLabel = new Label
            {
                Text = result.StudentName,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(20, 15),
                AutoSize = true,
                MaximumSize = new Size(400, 0)
            };
            card.Controls.Add(nameLabel);

            // Score with color coding
            Color scoreColor = GetScoreColor(result.Score);
            Label scoreLabel = new Label
            {
                Text = $"Score: {result.Score}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = scoreColor,
                Location = new Point(20, 45),
                AutoSize = true
            };
            card.Controls.Add(scoreLabel);

            // Date taken
            Label dateLabel = new Label
            {
                Text = $"Taken: {result.TakenDate:MMM dd, yyyy 'at' HH:mm}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(128, 128, 128),
                Location = new Point(20, 70),
                AutoSize = true
            };
            card.Controls.Add(dateLabel);

            // View answers button
            SimpleButton viewButton = new SimpleButton
            {
                Text = "View Answers",
                Size = new Size(120, 35),
                Location = new Point(20, 100),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            // Style the button
            viewButton.Appearance.BackColor = Color.FromArgb(128, 255, 128);
            viewButton.Appearance.BorderColor = Color.FromArgb(128, 255, 128);
            viewButton.Appearance.ForeColor = Color.White;
            viewButton.Appearance.Options.UseBackColor = true;
            viewButton.Appearance.Options.UseBorderColor = true;
            viewButton.Appearance.Options.UseForeColor = true;
            viewButton.AppearanceHovered.BackColor = Color.FromArgb(0, 192, 0);
            viewButton.AppearanceHovered.BorderColor = Color.FromArgb(0, 192, 0);
            viewButton.AppearanceHovered.Options.UseBackColor = true;
            viewButton.AppearanceHovered.Options.UseBorderColor = true;
            viewButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            viewButton.Click += (sender, e) => ShowStudentAnswers(result);
            card.Controls.Add(viewButton);

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

        private Color GetScoreColor(int score)
        {
            if (score >= 80) return Color.FromArgb(0, 128, 0); // Green for high scores
            if (score >= 60) return Color.FromArgb(255, 165, 0); // Orange for medium scores
            return Color.FromArgb(220, 53, 69); // Red for low scores
        }

        private void ShowStudentAnswers(ResultItem result)
        {
            var answers = AnswerDAL.GetAnswersByStudentExam(result.StudentId, result.ExamId);
            
            if (answers == null || answers.Count == 0)
            {
                MessageBox.Show("No answers found for this student.", "No Answers", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create detailed answers view
            string details = $"📋 Student Answers\n" +
                           $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n" +
                           $"👤 Student: {result.StudentName}\n" +
                           $"📊 Score: {result.Score}\n" +
                           $"📅 Date: {result.TakenDate:MMMM dd, yyyy 'at' HH:mm}\n\n" +
                           $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n";

            foreach (var answer in answers)
            {
                // Get question details
                var question = QuestionDAL.GetQuestionById(answer.QuestionId);
                if (question != null)
                {
                    details += $"❓ Question: {question.QuestionText}\n";
                    details += $"📝 Answer: {answer.AnswerText}\n";
                    details += $"📊 Type: {question.QuestionType.ToUpper()}\n\n";
                }
            }

            details += $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n" +
                      $"💡 Total Questions Answered: {answers.Count}";

            MessageBox.Show(details, "📋 Student Answers", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ManageResultsForm_Load(object sender, EventArgs e)
        {
            // Form is already loaded with exams
        }

        private class ResultItem
        {
            public int Id { get; set; }
            public int ExamId { get; set; }
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public int Score { get; set; }
            public DateTime TakenDate { get; set; }
        }
    }
}
