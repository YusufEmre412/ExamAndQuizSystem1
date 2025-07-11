using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamAndQuizSystem.Models;

namespace ExamAndQuizSystem.DataAccess
{
    public static class AnswerDAL
    {
        // Add new answer
        public static bool AddAnswer(Answer answer)
        {
            using (var conn = DataBase.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
INSERT INTO Answers (StudentId, QuestionId, AnswerText)
VALUES (@sid, @qid, @text);";
                    cmd.Parameters.AddWithValue("@sid", answer.StudentId);
                    cmd.Parameters.AddWithValue("@qid", answer.QuestionId);
                    cmd.Parameters.AddWithValue("@text", answer.AnswerText);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Get all the answers from a students exam
        public static List<Answer> GetAnswersByStudentExam(int studentId, int examId)
        {
            var list = new List<Answer>();
            using (var conn = DataBase.GetConnection()) { 
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
SELECT a.Id, a.StudentId, a.QuestionId, a.AnswerText
  FROM Answers a
  JOIN Questions q ON a.QuestionId = q.Id
 WHERE a.StudentId = @sid
   AND q.ExamId    = @eid;";
                cmd.Parameters.AddWithValue("@sid", studentId);
                cmd.Parameters.AddWithValue("@eid", examId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Answer
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            StudentId = Convert.ToInt32(reader["StudentId"]),
                            QuestionId = Convert.ToInt32(reader["QuestionId"]),
                            AnswerText = reader["AnswerText"].ToString()
                        });
                    }
                }
            }
            }
            return list;
        }

    }
}
