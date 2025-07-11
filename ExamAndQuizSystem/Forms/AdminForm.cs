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
    public partial class AdminForm : Form
    {
        private readonly Users _admin;

        public AdminForm(Users admin)
        {
            InitializeComponent();
            _admin = admin;
            Text = $"Admin Panel - {_admin.FullName}";

            // Role combobox doldur
            cmbRole.Items.Add("teacher");
            cmbRole.Items.Add("student");
            cmbRole.SelectedIndex = 0;

            LoadUsers();
            btnCreateUser.Click += btnCreateUser_Click;
        }

        private void LoadUsers()
        {
            List<Users> all = UserDAL.GetAllUsers();
            gridUsers.DataSource = all;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            var fullName = txtFullName.Text.Trim();
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;
            var role = cmbRole.SelectedItem.ToString();

            if (fullName == "" || username == "" || password == "")
            {
                MessageBox.Show("All fields are required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // var mı kontrol et
            if (UserDAL.GetUser(username, password) != null)
            {
                MessageBox.Show("Username already exists.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new Users
            {
                FullName = fullName,
                Username = username,
                Password = password,
                Role = role
            };

            if (UserDAL.AddUser(user))
            {
                MessageBox.Show("User created.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                txtFullName.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Could not create user.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void gridUsers_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
