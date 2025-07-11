using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAndQuizSystem.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TeacherId { get; set; }
        public DateTime Date { get; set; }
        public bool Published { get; set; }
    }
}
