using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors;
using ExamAndQuizSystem.Models;
using ExamAndQuizSystem.DataAccess;
using ExamAndQuizSystem.Forms;

namespace ExamAndQuizSystem.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int x = (this.ClientSize.Width - panelLoginCard.Width) / 2;
            int y = (this.ClientSize.Height - panelLoginCard.Height) / 2;

            panelLoginCard.Location = new Point(x, y);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user)|| string.IsNullOrEmpty(pass))
            {
                XtraMessageBox.Show("Please enter both username and password!", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Users loggedIn = UserDAL.GetUser(user, pass);
            if(loggedIn == null)
            {
                XtraMessageBox.Show("Invalid username or password.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            if (loggedIn.Role.Equals("teacher", StringComparison.OrdinalIgnoreCase))
            {
                var teacherForm = new TeacherForm(loggedIn);
                teacherForm.ShowDialog();

            }
            else if (loggedIn.Role.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                using (var adminForm = new AdminForm(loggedIn))
                    adminForm.ShowDialog();
            }

            else
            {
                var studentForm = new StudentForm(loggedIn);
                studentForm.ShowDialog();
            }
            this.Close();

        }

        private void panelLoginCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_resize(object sender, EventArgs e)
        {

        }

        private void LoginFormResize(object sender, EventArgs e)
        {
            int x = (this.ClientSize.Width - panelLoginCard.Width) / 2;
            int y = (this.ClientSize.Height - panelLoginCard.Height) / 2;

            panelLoginCard.Location = new Point(x, y);
        }

        private void txtUsername_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}

