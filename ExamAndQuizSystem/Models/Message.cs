using System;

namespace ExamAndQuizSystem.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string MessageText { get; set; }
        public DateTime SentTime { get; set; }
        public bool IsRead { get; set; }
    }
}
