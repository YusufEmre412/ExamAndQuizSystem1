using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamAndQuizSystem.DataAccess;
using ExamAndQuizSystem.Models;



namespace ExamAndQuizSystem
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            DataBase.Initialize(); //Initialize database if exists, if not create one
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "The Bezier";
            var adminUser = new Users
            {
                FullName = "System Administrator",
                Username = "admin",
                Password = "admin123",   // sonradan değiştirebilsin
                Role = "admin"
            };
            if (UserDAL.GetUser(adminUser.Username, adminUser.Password) == null)
                UserDAL.AddUser(adminUser);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.LoginForm());
        }
    }
}
