using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamAndQuizSystem.Models;
using ExamAndQuizSystem.DataAccess;
using DevExpress.XtraEditors;

namespace ExamAndQuizSystem.Forms
{
    public partial class ResultForm : Form
    {
        private readonly Users _student;
        private List<Result> _results;
        private List<Exam> _exams;

        public ResultForm(Users student)
        {
            InitializeComponent();
            _student = student;
            Text = $"My Grades - {_student.FullName}";
            labelTitle.Text = $"My Grades - {_student.FullName}";

            LoadResults();
        }

        private void LoadResults()
        {
            // Load student results and exams
            _results = ResultDAL.GetResultsByStudent(_student.Id);
            _exams = ExamDAL.GetAllExams();

            CreateResultCards();
        }

        private void CreateResultCards()
        {
            panelResults.Controls.Clear();

            if (_results == null || _results.Count == 0)
            {
                // Show no results message
                Label noResultsLabel = new Label
                {
                    Text = "You haven't taken any exams yet.",
                    Font = new Font("Segoe UI", 14, FontStyle.Regular),
                    ForeColor = Color.FromArgb(128, 128, 128),
                    AutoSize = true,
                    Location = new Point(20, 20)
                };
                panelResults.Controls.Add(noResultsLabel);
                return;
            }

            foreach (var result in _results)
            {
                // Find the corresponding exam
                var exam = _exams?.FirstOrDefault(e => e.Id == result.ExamId);
                string examTitle = exam?.Title ?? $"Exam #{result.ExamId}";

                // Create result card
                Panel resultCard = CreateResultCard(examTitle, result);
                panelResults.Controls.Add(resultCard);
            }
        }

        private Panel CreateResultCard(string examTitle, Result result)
        {
            Panel card = new Panel
            {
                Width = 400,
                Height = 200,
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

            // Exam title
            Label titleLabel = new Label
            {
                Text = examTitle,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(20, 20),
                AutoSize = true
            };
            card.Controls.Add(titleLabel);

            // Score
            Label scoreLabel = new Label
            {
                Text = $"Score: {result.Score}",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                ForeColor = GetScoreColor(result.Score),
                Location = new Point(20, 60),
                AutoSize = true
            };
            card.Controls.Add(scoreLabel);

            // Date taken
            Label dateLabel = new Label
            {
                Text = $"Taken: {result.TakenDate:MMM dd, yyyy}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(128, 128, 128),
                Location = new Point(20, 90),
                AutoSize = true
            };
            card.Controls.Add(dateLabel);

            // View details button
            SimpleButton viewButton = new SimpleButton
            {
                Text = "View Details",
                Size = new Size(120, 35),
                Location = new Point(20, 140),
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

            viewButton.Click += (sender, e) => ShowResultDetails(examTitle, result);
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

        private void ShowResultDetails(string examTitle, Result result)
        {
            // Create a more detailed result view
            string message = $"📋 Exam Details\n" +
                           $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n" +
                           $"📝 Exam: {examTitle}\n" +
                           $"📊 Score: {result.Score}\n" +
                           $"📅 Date Taken: {result.TakenDate:MMMM dd, yyyy 'at' HH:mm}\n" +
                           $"🆔 Result ID: {result.Id}\n\n" +
                           $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n" +
                           $"Performance: {GetPerformanceMessage(result.Score)}";

            XtraMessageBox.Show(message, "📊 Exam Result Details", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetPerformanceMessage(int score)
        {
            if (score >= 90) return "🎉 Excellent! Outstanding performance!";
            if (score >= 80) return "👍 Great job! Well done!";
            if (score >= 70) return "✅ Good work! Keep it up!";
            if (score >= 60) return "⚠️  Satisfactory. Room for improvement.";
            return "📚 Needs improvement. Consider reviewing the material.";
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            // Form is already loaded with results
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
