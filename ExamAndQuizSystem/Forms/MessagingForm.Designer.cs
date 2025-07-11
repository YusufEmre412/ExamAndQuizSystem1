namespace ExamAndQuizSystem.Forms
{
    partial class MessagingForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelChat = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.txtMessage = new DevExpress.XtraEditors.TextEdit();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.flowLayoutMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.panelChatHeader = new System.Windows.Forms.Panel();
            this.labelChatTitle = new System.Windows.Forms.Label();
            this.panelContacts = new System.Windows.Forms.Panel();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.labelContacts = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelChat.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            this.panelMessages.SuspendLayout();
            this.panelChatHeader.SuspendLayout();
            this.panelContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelMain.Controls.Add(this.panelChat);
            this.panelMain.Controls.Add(this.panelContacts);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1562, 985);
            this.panelMain.TabIndex = 0;
            // 
            // panelChat
            // 
            this.panelChat.BackColor = System.Drawing.Color.White;
            this.panelChat.Controls.Add(this.panelInput);
            this.panelChat.Controls.Add(this.panelMessages);
            this.panelChat.Controls.Add(this.panelChatHeader);
            this.panelChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChat.Location = new System.Drawing.Point(300, 0);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(1262, 985);
            this.panelChat.TabIndex = 1;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.Controls.Add(this.panel1);
            this.panelInput.Controls.Add(this.txtMessage);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 864);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1262, 121);
            this.panelInput.TabIndex = 2;
            this.panelInput.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInput_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1121, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 121);
            this.panel1.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSend.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSend.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSend.Appearance.Options.UseBackColor = true;
            this.btnSend.Appearance.Options.UseBorderColor = true;
            this.btnSend.Appearance.Options.UseFont = true;
            this.btnSend.Appearance.Options.UseForeColor = true;
            this.btnSend.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSend.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSend.AppearanceHovered.Options.UseBackColor = true;
            this.btnSend.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSend.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSend.Location = new System.Drawing.Point(18, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 63);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMessage.Properties.Appearance.Options.UseFont = true;
            this.txtMessage.Size = new System.Drawing.Size(1262, 32);
            this.txtMessage.TabIndex = 0;
            // 
            // panelMessages
            // 
            this.panelMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelMessages.Controls.Add(this.flowLayoutMessages);
            this.panelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessages.Location = new System.Drawing.Point(0, 60);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(1262, 925);
            this.panelMessages.TabIndex = 1;
            // 
            // flowLayoutMessages
            // 
            this.flowLayoutMessages.AutoScroll = true;
            this.flowLayoutMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.flowLayoutMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutMessages.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMessages.Name = "flowLayoutMessages";
            this.flowLayoutMessages.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutMessages.Size = new System.Drawing.Size(1262, 925);
            this.flowLayoutMessages.TabIndex = 0;
            this.flowLayoutMessages.WrapContents = false;
            // 
            // panelChatHeader
            // 
            this.panelChatHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.panelChatHeader.Controls.Add(this.labelChatTitle);
            this.panelChatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChatHeader.Location = new System.Drawing.Point(0, 0);
            this.panelChatHeader.Name = "panelChatHeader";
            this.panelChatHeader.Size = new System.Drawing.Size(1262, 60);
            this.panelChatHeader.TabIndex = 0;
            // 
            // labelChatTitle
            // 
            this.labelChatTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChatTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelChatTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelChatTitle.Location = new System.Drawing.Point(0, 0);
            this.labelChatTitle.Name = "labelChatTitle";
            this.labelChatTitle.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.labelChatTitle.Size = new System.Drawing.Size(1262, 60);
            this.labelChatTitle.TabIndex = 0;
            this.labelChatTitle.Text = "Select a contact to start chatting";
            this.labelChatTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContacts
            // 
            this.panelContacts.BackColor = System.Drawing.Color.White;
            this.panelContacts.Controls.Add(this.listBoxContacts);
            this.panelContacts.Controls.Add(this.labelContacts);
            this.panelContacts.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContacts.Location = new System.Drawing.Point(0, 0);
            this.panelContacts.Name = "panelContacts";
            this.panelContacts.Size = new System.Drawing.Size(300, 985);
            this.panelContacts.TabIndex = 0;
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.BackColor = System.Drawing.Color.White;
            this.listBoxContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContacts.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.ItemHeight = 25;
            this.listBoxContacts.Location = new System.Drawing.Point(0, 60);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(300, 925);
            this.listBoxContacts.TabIndex = 1;
            // 
            // labelContacts
            // 
            this.labelContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.labelContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelContacts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelContacts.Location = new System.Drawing.Point(0, 0);
            this.labelContacts.Name = "labelContacts";
            this.labelContacts.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.labelContacts.Size = new System.Drawing.Size(300, 60);
            this.labelContacts.TabIndex = 0;
            this.labelContacts.Text = "Select Contact";
            this.labelContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessagingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 985);
            this.Controls.Add(this.panelMain);
            this.Name = "MessagingForm";
            this.Text = "Messages";
            this.panelMain.ResumeLayout(false);
            this.panelChat.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            this.panelMessages.ResumeLayout(false);
            this.panelChatHeader.ResumeLayout(false);
            this.panelContacts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContacts;
        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.Label labelContacts;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Panel panelChatHeader;
        private System.Windows.Forms.Label labelChatTitle;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMessages;
        private System.Windows.Forms.Panel panelInput;
        private DevExpress.XtraEditors.TextEdit txtMessage;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private System.Windows.Forms.Panel panel1;
    }
}