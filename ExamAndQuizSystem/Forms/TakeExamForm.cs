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
using System.Linq;

namespace ExamAndQuizSystem.Forms
{
    public partial class TakeExamForm : Form
    {
        private readonly Exam _exam;
        private readonly Users _student;
        private readonly List<Question> _questions;
        private readonly Dictionary<int, string> _answers = new Dictionary<int, string>();

        private int _currentIndex = 0;

        public TakeExamForm(Exam exam, Users student)
        {
            InitializeComponent();
            _exam = exam;
            _student = student;
            
            // Set form styling
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Check if exam is published
            if (!_exam.Published)
            {
                MessageBox.Show("This exam is not yet published and cannot be taken.", 
                    "Exam Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }
            
            lblExamTitle.Text = $"Exam: {_exam.Title}";
            lblExamTitle.Appearance.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblExamTitle.Appearance.ForeColor = Color.FromArgb(44, 62, 80);
            
            _questions = QuestionDAL.GetQuestionsByExam(_exam.Id);

            ShowQuestion(0);
        }

        private void ShowQuestion(int index)
        {
            panelQuestionHost.Controls.Clear();
            panelQuestionHost.BackColor = Color.FromArgb(248, 249, 250); // Light gray background
            
            var q = _questions[index];
            
            // Create a main container panel for better organization
            var mainContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                AutoScroll = true
            };
            panelQuestionHost.Controls.Add(mainContainer);
            
            // Question number and progress indicator
            var progressPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(52, 152, 219), // Blue background
                Padding = new Padding(15)
            };
            
            var questionNumberLabel = new Label
            {
                Text = $"Question {index + 1} of {_questions.Count}",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(15, 15)
            };
            progressPanel.Controls.Add(questionNumberLabel);
            
            // Progress bar - right aligned
            var progressBar = new ProgressBar
            {
                Value = (int)((double)(index + 1) / _questions.Count * 100),
                Width = 200,
                Height = 8,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Top = (progressPanel.Height - 8) / 2,
                Left = progressPanel.Width - 230 // 15px right margin + 200 width + 15px left padding
            };
            // Dynamically update position on resize
            progressPanel.Resize += (s, e) => {
                progressBar.Left = progressPanel.Width - progressBar.Width - 15;
                progressBar.Top = (progressPanel.Height - progressBar.Height) / 2;
            };
            progressPanel.Controls.Add(progressBar);
            mainContainer.Controls.Add(progressPanel);

            // --- QUESTION DESCRIPTION (directly under blue bar) ---
            var questionDescriptionLabel = new Label
            {
                Text = q.QuestionText,
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                ForeColor = Color.FromArgb(44, 62, 80),
                AutoSize = false,
                Width = mainContainer.Width - 80,
                Height = 0,
                Padding = new Padding(0, 20, 0, 20),
                Location = new Point(20, progressPanel.Bottom + 20)
            };
            using (var g = CreateGraphics())
            {
                var size = g.MeasureString(q.QuestionText, questionDescriptionLabel.Font, questionDescriptionLabel.Width);
                questionDescriptionLabel.Height = (int)size.Height + 40;
            }
            mainContainer.Controls.Add(questionDescriptionLabel);
            // --- END QUESTION DESCRIPTION ---

            // Add answer controls based on question type
            int answerStartY = questionDescriptionLabel.Bottom + 10;
            switch (q.QuestionType)
            {
                case "mcq":
                    AddMcqControls(q, index, mainContainer, answerStartY);
                    break;
                case "fill":
                    AddFillControls(q, index, mainContainer, answerStartY);
                    break;
                case "code":
                    AddCodeControls(q, index, mainContainer, answerStartY);
                    break;
            }

            btnPrev.Enabled = (index > 0);
            btnNext.Enabled = (index < _questions.Count - 1);
            btnFinish.Visible = (index == _questions.Count - 1);
            
            // Update button styling for better visual feedback
            if (btnPrev.Enabled)
            {
                btnPrev.Appearance.BackColor = Color.FromArgb(52, 152, 219);
                btnPrev.Appearance.ForeColor = Color.White;
            }
            else
            {
                btnPrev.Appearance.BackColor = Color.FromArgb(189, 195, 199);
                btnPrev.Appearance.ForeColor = Color.FromArgb(149, 165, 166);
            }
            
            if (btnNext.Enabled)
            {
                btnNext.Appearance.BackColor = Color.FromArgb(46, 204, 113);
                btnNext.Appearance.ForeColor = Color.White;
            }
            else
            {
                btnNext.Appearance.BackColor = Color.FromArgb(189, 195, 199);
                btnNext.Appearance.ForeColor = Color.FromArgb(149, 165, 166);
            }
            
            if (btnFinish.Visible)
            {
                btnFinish.Appearance.BackColor = Color.FromArgb(231, 76, 60);
                btnFinish.Appearance.ForeColor = Color.White;
            }
        }
        
        private string GetQuestionTypeDisplay(string questionType)
        {
            switch (questionType.ToLower())
            {
                case "mcq": return "Multiple Choice Question";
                case "fill": return "Fill in the Blank";
                case "code": return "Coding Question";
                default: return "Question";
            }
        }

        private void AddMcqControls(Question q, int idx, Panel container, int startY)
        {
            var options = OptionDAL.GetOptionsByQuestion(q.Id);
            var optionsContainer = new Panel
            {
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 20),
                Padding = new Padding(20),
                BorderStyle = BorderStyle.None,
                Location = new Point(0, startY),
                Width = container.Width - 40 // Ensure it fits within the container
            };
            
            var optionsLabel = new Label
            {
                Text = "Select your answer:",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                AutoSize = true,
                Location = new Point(20, 20)
            };
            optionsContainer.Controls.Add(optionsLabel);
            
            int top = 60;
            char optionLetter = 'A';
            
            foreach (var opt in options)
            {
                var optionPanel = new Panel
                {
                    BackColor = Color.FromArgb(248, 249, 250),
                    Margin = new Padding(0, 5, 0, 5),
                    Padding = new Padding(15),
                    Height = 50,
                    Width = optionsContainer.Width - 40, // Adjust width to fit container
                    Location = new Point(20, top)
                };
                
                var rb = new RadioButton
                {
                    Text = $"{optionLetter}. {opt.OptionText}",
                    Tag = opt.Id,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11),
                    ForeColor = Color.FromArgb(44, 62, 80),
                    Location = new Point(15, 15),
                    Width = optionPanel.Width - 30
                };
                
                // Pre-select if answer exists
                if (_answers.TryGetValue(q.Id, out var prev) && prev == opt.OptionText)
                    rb.Checked = true;
                
                optionPanel.Controls.Add(rb);
                optionsContainer.Controls.Add(optionPanel);
                
                // Hover effect
                optionPanel.MouseEnter += (s, e) => {
                    optionPanel.BackColor = Color.FromArgb(236, 240, 241);
                };
                optionPanel.MouseLeave += (s, e) => {
                    optionPanel.BackColor = Color.FromArgb(248, 249, 250);
                };
                
                top += 60;
                optionLetter++;
            }
            
            optionsContainer.Height = top + 20;
            container.Controls.Add(optionsContainer);
        }

        private void AddFillControls(Question q, int idx, Panel container, int startY)
        {
            var fillContainer = new Panel
            {
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 20),
                Padding = new Padding(20),
                BorderStyle = BorderStyle.None,
                Location = new Point(0, startY),
                Width = container.Width - 40 // Ensure it fits within the container
            };
            
            var instructionLabel = new Label
            {
                Text = "Enter your answer:",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                AutoSize = true,
                Location = new Point(20, 20)
            };
            fillContainer.Controls.Add(instructionLabel);
            
            var tb = new TextBox
            {
                Font = new Font("Segoe UI", 12),
                BackColor = Color.FromArgb(248, 249, 250),
                ForeColor = Color.FromArgb(44, 62, 80),
                BorderStyle = BorderStyle.FixedSingle,
                Width = fillContainer.Width - 40, // Adjust width to fit container
                Height = 40,
                Location = new Point(20, 50),
                Text = _answers.ContainsKey(q.Id) ? _answers[q.Id] : "",
                Padding = new Padding(10, 8, 10, 8)
            };
            
            fillContainer.Controls.Add(tb);
            fillContainer.Height = 110;
            container.Controls.Add(fillContainer);
        }

        private void AddCodeControls(Question q, int idx, Panel container, int startY)
        {
            var codeContainer = new Panel
            {
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 20),
                Padding = new Padding(20),
                BorderStyle = BorderStyle.None,
                Location = new Point(0, startY),
                Width = container.Width - 40 // Ensure it fits within the container
            };
            
            var instructionLabel = new Label
            {
                Text = "Write your code:",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                AutoSize = true,
                Location = new Point(20, 20)
            };
            codeContainer.Controls.Add(instructionLabel);
            
            var tb = new TextBox
            {
                Multiline = true,
                Font = new Font("Consolas", 11),
                BackColor = Color.FromArgb(44, 62, 80), // Dark background for code
                ForeColor = Color.FromArgb(236, 240, 241), // Light text
                BorderStyle = BorderStyle.FixedSingle,
                Width = codeContainer.Width - 40, // Adjust width to fit container
                Height = 300,
                Location = new Point(20, 50),
                Text = _answers.ContainsKey(q.Id) ? _answers[q.Id] : "",
                ScrollBars = ScrollBars.Vertical,
                AcceptsTab = true,
                WordWrap = false
            };
            
            codeContainer.Controls.Add(tb);
            codeContainer.Height = 370;
            container.Controls.Add(codeContainer);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            ShowQuestion(++_currentIndex);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            ShowQuestion(--_currentIndex);
        }

        private void SaveCurrentAnswer()
        {
            var q = _questions[_currentIndex];
            string answer = "";

            if (q.QuestionType == "mcq")
            {
                // Find the main container first
                var mainContainer = panelQuestionHost.Controls.OfType<Panel>().FirstOrDefault();
                if (mainContainer != null)
                {
                    // Look for radio buttons in the options container
                    var optionsContainer = mainContainer.Controls.OfType<Panel>().Skip(1).FirstOrDefault(); // Skip progress panel
                    if (optionsContainer != null)
                    {
                        foreach (Control optionPanel in optionsContainer.Controls)
                        {
                            if (optionPanel is Panel)
                            {
                                foreach (Control c in optionPanel.Controls)
                                {
                                    if (c is RadioButton rb && rb.Checked)
                                    {
                                        // Extract the answer text without the option letter
                                        answer = rb.Text.Substring(rb.Text.IndexOf('.') + 2);
                                        break;
                                    }
                                }
                                if (!string.IsNullOrEmpty(answer)) break;
                            }
                        }
                    }
                }
            }
            else if (q.QuestionType == "fill" || q.QuestionType == "code")
            {
                // Find the main container first
                var mainContainer = panelQuestionHost.Controls.OfType<Panel>().FirstOrDefault();
                if (mainContainer != null)
                {
                    // Look for text boxes in the answer containers
                    var answerContainer = mainContainer.Controls.OfType<Panel>().Skip(1).FirstOrDefault(); // Skip progress panel
                    if (answerContainer != null)
                    {
                        foreach (Control c in answerContainer.Controls)
                        {
                            if (c is TextBox tb)
                            {
                                answer = tb.Text.Trim();
                                break;
                            }
                        }
                    }
                }
            }

            if (_answers.ContainsKey(q.Id))
                _answers[q.Id] = answer;
            else
                _answers.Add(q.Id, answer);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            // 1) Son cevabı kaydet
            SaveCurrentAnswer();

            // 2) Tüm cevapları veritabanına kaydet
            foreach (var q in _questions)
            {
                AnswerDAL.AddAnswer(new Answer
                {
                    StudentId = _student.Id,
                    QuestionId = q.Id,
                    AnswerText = _answers.TryGetValue(q.Id, out var txt) ? txt : ""
                });
            }

            // 3) Otomatik değerlendirme: MCQ ve Fill tipi
            int correctCount = 0;
            int totalAuto = 0;

            foreach (var q in _questions)
            {
                if (q.QuestionType == "mcq")
                {
                    totalAuto++;
                    // MCQ için doğru şıkkı çek
                    var options = OptionDAL.GetOptionsByQuestion(q.Id);
                    var correctOption = options.FirstOrDefault(o => o.IsCorrect);
                    if (correctOption != null
                        && _answers.TryGetValue(q.Id, out var mcqAnswer)
                        && string.Equals(mcqAnswer, correctOption.OptionText, StringComparison.OrdinalIgnoreCase))
                    {
                        correctCount++;
                    }
                }
                else if (q.QuestionType == "fill")
                {
                    totalAuto++;
                    if (_answers.TryGetValue(q.Id, out var fillAnswer)
                        && string.Equals(fillAnswer, q.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
                    {
                        correctCount++;
                    }
                }
                // 'code' tipi öğretmen tarafından elle değerlendirilecek, sayılmıyor
            }

            // 4) Sonucu Results tablosuna ekle
            var result = new Result
            {
                StudentId = _student.Id,
                ExamId = _exam.Id,
                Score = correctCount,
                TakenDate = DateTime.Now
            };
            ResultDAL.AddResult(result);

            // 5) Sonuç bilgisini göster
            MessageBox.Show(
                $"You answered {correctCount} out of {totalAuto} automatically-graded questions correctly.",
                "Exam Completed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }

        private void TakeExamForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            ShowQuestion(--_currentIndex);
        }
    }
}
