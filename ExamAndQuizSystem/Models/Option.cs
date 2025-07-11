using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAndQuizSystem.Models
{
    public class Option
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string OptionText { get; set; }
        public bool IsCorrect { get; set; } // true /false


    }
}
