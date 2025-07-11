using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAndQuizSystem.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password{ get; set; } // Sonradan burayi hashlerim belki 
        public string Role { get; set; } // Teacher or Student
    }
}
