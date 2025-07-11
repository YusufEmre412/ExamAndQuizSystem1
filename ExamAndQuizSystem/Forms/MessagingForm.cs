using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ExamAndQuizSystem.DataAccess;
using ExamAndQuizSystem.Models;
using MessageModel = ExamAndQuizSystem.Models.Message;

namespace ExamAndQuizSystem.Forms
{
    public partial class MessagingForm : Form
    {
        private Users currentUser;
        private Users selectedContact;
        private List<Users> contacts;
        private List<MessageModel> currentMessages;

        public MessagingForm(Users user)
        {
            InitializeComponent();
            currentUser = user;
            contacts = new List<Users>();
            currentMessages = new List<MessageModel>();
            
            LoadContacts();
            SetupEventHandlers();
        }

        private void LoadContacts()
        {
            contacts.Clear();
            listBoxContacts.Items.Clear();

            // Get all users first
            var allUsers = UserDAL.GetAllUsers();

            if (currentUser.Role.ToLower() == "student")
            {
                // Students can message teachers
                var teachers = allUsers.Where(u => u.Role.ToLower() == "teacher").ToList();
                contacts = teachers.Where(u => u.Id != currentUser.Id).ToList();
            }
            else if (currentUser.Role.ToLower() == "teacher")
            {
                // Teachers can message students
                var students = allUsers.Where(u => u.Role.ToLower() == "student").ToList();
                contacts = students.Where(u => u.Id != currentUser.Id).ToList();
            }

            foreach (var contact in contacts)
            {
                listBoxContacts.Items.Add(contact.FullName);
            }
        }

        private void SetupEventHandlers()
        {
            listBoxContacts.SelectedIndexChanged += ListBoxContacts_SelectedIndexChanged;
            btnSend.Click += BtnSend_Click;
            txtMessage.KeyPress += TxtMessage_KeyPress;
        }

        private void ListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContacts.SelectedIndex >= 0)
            {
                selectedContact = contacts[listBoxContacts.SelectedIndex];
                LoadMessages();
            }
        }

        private void LoadMessages()
        {
            if (selectedContact == null) return;

            currentMessages = MessageDAL.GetConversation(currentUser.Id, selectedContact.Id);
            DisplayMessages();
        }

        private void DisplayMessages()
        {
            flowLayoutMessages.Controls.Clear();

            foreach (var message in currentMessages)
            {
                var messagePanel = CreateMessagePanel(message);
                flowLayoutMessages.Controls.Add(messagePanel);
            }

            // Scroll to bottom
            flowLayoutMessages.VerticalScroll.Value = flowLayoutMessages.VerticalScroll.Maximum;
        }

        private Panel CreateMessagePanel(MessageModel message)
        {
            bool isMyMessage = message.SenderId == currentUser.Id;
            
            // Create container panel
            Panel container = new Panel
            {
                Width = flowLayoutMessages.Width - 20,
                Height = 60,
                Margin = new Padding(5),
                BackColor = Color.Transparent
            };

            // Create message bubble panel
            Panel bubble = new Panel
            {
                Width = 400,
                Height = 60,
                BackColor = isMyMessage ? Color.FromArgb(128, 255, 128) : Color.White,
                BorderStyle = BorderStyle.None
            };

            // Position the bubble
            if (isMyMessage)
            {
                // Sent message - dock to right
                bubble.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                bubble.Location = new Point(container.Width - bubble.Width - 10, 5);
            }
            else
            {
                // Received message - dock to left
                bubble.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                bubble.Location = new Point(10, 5);
            }

            // Add shadow effect
            bubble.Paint += (sender, e) =>
            {
                // Shadow
                using (var shadowBrush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                {
                    e.Graphics.FillRectangle(shadowBrush, 2, 2, bubble.Width - 4, bubble.Height - 4);
                }
                
                // Border
                using (var borderPen = new Pen(Color.FromArgb(240, 240, 240), 1))
                {
                    e.Graphics.DrawRectangle(borderPen, 0, 0, bubble.Width - 1, bubble.Height - 1);
                }
            };

            // Message text
            Label messageLabel = new Label
            {
                Text = message.MessageText,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = isMyMessage ? Color.FromArgb(0, 0, 0) : Color.FromArgb(64, 64, 64),
                Location = new Point(10, 10),
                AutoSize = true,
                MaximumSize = new Size(350, 0),
                BackColor = Color.Transparent
            };
            bubble.Controls.Add(messageLabel);

            // Time label
            Label timeLabel = new Label
            {
                Text = message.SentTime.ToString("HH:mm"),
                Font = new Font("Segoe UI", 8),
                ForeColor = isMyMessage ? Color.FromArgb(64, 64, 64) : Color.FromArgb(128, 128, 128),
                Location = new Point(10, 35),
                AutoSize = true,
                BackColor = Color.Transparent
            };
            bubble.Controls.Add(timeLabel);

            container.Controls.Add(bubble);
            return container;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void TxtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendMessage();
            }
        }

        private void SendMessage()
        {
            if (selectedContact == null)
            {
                MessageBox.Show("Please select a contact first.", "No Contact Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                return;
            }

            var message = new MessageModel
            {
                SenderId = currentUser.Id,
                ReceiverId = selectedContact.Id,
                MessageText = txtMessage.Text.Trim(),
                SentTime = DateTime.Now,
                IsRead = false
            };

            if (MessageDAL.AddMessage(message))
            {
                txtMessage.Text = "";
                LoadMessages();
            }
            else
            {
                MessageBox.Show("Failed to send message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelInput_Paint(object sender, PaintEventArgs e)
        {
            // Empty paint event handler
        }
    }
}
