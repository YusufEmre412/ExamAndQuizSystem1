using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAndQuizSystem.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; } // mcq, fill, code
        public string CorrectAnswer { get; set; } // for fill and code questions
    }
}
