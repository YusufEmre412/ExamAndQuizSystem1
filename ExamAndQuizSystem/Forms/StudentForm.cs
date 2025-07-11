using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using ExamAndQuizSystem.Models;
using ExamAndQuizSystem.DataAccess;

namespace ExamAndQuizSystem.Forms
{
    public partial class StudentForm : Form
    {
        private readonly Users _currentUser;
        private List<Exam> _availableExams;

        public StudentForm(Users user)
        {
            InitializeComponent();
            _currentUser = user;
            Text = $"Student Panel - {_currentUser.FullName}";

            // Load available exams (only published ones)
            _availableExams = ExamDAL.GetPublishedExams();

            // Show welcome labels initially
            ShowWelcomeScreen();

            // Event handlers
            btnTakeExam.Click += btnTakeExam_Click;
            btnMyGrades.Click += btnMyGrades_Click;
            btnMessages.Click += btnMessages_Click;
            simpleButton1.Click += simpleButton1_Click;
        }

        private void ShowWelcomeScreen()
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(panelExams);
            
            // Show welcome labels
            labelWelcome.Visible = true;
            labelSubtitle.Visible = true;
            
            // Hide exam title
            labelExamsTitle.Visible = false;
        }

        // Show available exams in card format
        private void btnTakeExam_Click(object sender, EventArgs e)
        {
            panelExams.FlowDirection = FlowDirection.LeftToRight;
            ShowAvailableExams();
        }

        private void ShowAvailableExams()
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(labelExamsTitle);
            panel2.Controls.Add(panelExams);

            // Hide welcome labels when showing exams
            labelWelcome.Visible = false;
            labelSubtitle.Visible = false;
            
            // Show exam title
            labelExamsTitle.Visible = true;

            CreateExamCards();
        }

        private void CreateExamCards()
        {
            panelExams.Controls.Clear();

            if (_availableExams == null || _availableExams.Count == 0)
            {
                // Show no exams message
               
            }

            // Sort exams by ID (most recent first) and create cards
            var sortedExams = _availableExams.OrderByDescending(e => e.Id).ToList();

            foreach (var exam in sortedExams)
            {
                Panel examCard = CreateExamCard(exam);
                panelExams.Controls.Add(examCard);
            }
        }

        private Panel CreateExamCard(Exam exam)
        {
            Panel card = new Panel
            {
                Width = 350,
                Height = 200,
                Margin = new Padding(15),
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
                Text = exam.Title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                Location = new Point(15, 15),
                AutoSize = true,
                MaximumSize = new Size(320, 0)
            };
            card.Controls.Add(titleLabel);

            // Exam date
            Label dateLabel = new Label
            {
                Text = $"Date: {exam.Date:MMM dd, yyyy}",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(128, 128, 128),
                Location = new Point(15, 50),
                AutoSize = true
            };
            card.Controls.Add(dateLabel);

            // Exam ID (for reference)
            Label idLabel = new Label
            {
                Text = $"Exam ID: {exam.Id}",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.FromArgb(160, 160, 160),
                Location = new Point(15, 75),
                AutoSize = true
            };
            card.Controls.Add(idLabel);

            // Take exam button
            SimpleButton takeButton = new SimpleButton
            {
                Text = "Take This Exam",
                Size = new Size(140, 40),
                Location = new Point(15, 140),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            // Style the button
            takeButton.Appearance.BackColor = Color.FromArgb(128, 255, 128);
            takeButton.Appearance.BorderColor = Color.FromArgb(128, 255, 128);
            takeButton.Appearance.ForeColor = Color.White;
            takeButton.Appearance.Options.UseBackColor = true;
            takeButton.Appearance.Options.UseBorderColor = true;
            takeButton.Appearance.Options.UseForeColor = true;
            takeButton.AppearanceHovered.BackColor = Color.FromArgb(0, 192, 0);
            takeButton.AppearanceHovered.BorderColor = Color.FromArgb(0, 192, 0);
            takeButton.AppearanceHovered.Options.UseBackColor = true;
            takeButton.AppearanceHovered.Options.UseBorderColor = true;
            takeButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            takeButton.Click += (sender, e) => StartExam(exam);
            card.Controls.Add(takeButton);

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

        private void StartExam(Exam exam)
        {
            // Show confirmation dialog
            var result = XtraMessageBox.Show(
                $"Are you sure you want to start the exam '{exam.Title}'?\n\n" +
                "Once you start, you cannot go back until you finish the exam.",
                "Start Exam",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                panel2.Controls.Clear();
                var takeForm = new TakeExamForm(exam, _currentUser)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                
                // Handle form closing to show welcome screen
                takeForm.FormClosed += (s, args) => ShowWelcomeScreen();
                
                panel2.Controls.Add(takeForm);
                takeForm.Show();
            }
        }

        private void btnMyGrades_Click(object sender, EventArgs e)
        {
            // Hide welcome labels when showing grades
            panelExams.FlowDirection = FlowDirection.LeftToRight;
            labelWelcome.Visible = false;
            labelSubtitle.Visible = false;

            panel2.Controls.Clear();
            var gradesForm = new ResultForm(_currentUser)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            
            // Handle form closing to show welcome screen
            gradesForm.FormClosed += (s, args) => ShowWelcomeScreen();
            
            panel2.Controls.Add(gradesForm);
            gradesForm.Show();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            // Hide welcome labels when showing messages
            labelWelcome.Visible = false;
            labelSubtitle.Visible = false;

            panel2.Controls.Clear();
            var messagingForm = new MessagingForm(_currentUser)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            
            // Handle form closing to show welcome screen
            messagingForm.FormClosed += (s, args) => ShowWelcomeScreen();
            
            panel2.Controls.Add(messagingForm);
            messagingForm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Logout
            Hide();
            using (var login = new LoginForm())
                login.ShowDialog();
            Close();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
