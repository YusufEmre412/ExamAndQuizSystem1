using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamAndQuizSystem.Models;

namespace ExamAndQuizSystem.DataAccess
{
    public static class QuestionDAL
    {
        public static int AddQuestion(Question question)
        {
            int newId = -1;
            using (var conn = DataBase.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
INSERT INTO Questions (ExamId, QuestionText, QuestionType, CorrectAnswer)
VALUES (@examId, @qText, @qType, @cAnswer);
SELECT last_insert_rowid();";

                    cmd.Parameters.AddWithValue("@examId", question.ExamId);
                    cmd.Parameters.AddWithValue("@qText", question.QuestionText);
                    cmd.Parameters.AddWithValue("@qType", question.QuestionType);
                    cmd.Parameters.AddWithValue("@cAnswer", question.CorrectAnswer ?? "");

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        newId = id;
                    }



                }
            }
            return newId;
        }

        public static List<Question> GetQuestionsByExam(int examId)
        {
            var list = new List<Question>();

            using (var conn = DataBase.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
SELECT * FROM Questions 
 WHERE ExamId = @examId;";
                    cmd.Parameters.AddWithValue("@examId", examId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Question
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ExamId = Convert.ToInt32(reader["ExamId"]),
                                QuestionText = reader["QuestionText"].ToString(),
                                QuestionType = reader["QuestionType"].ToString(),
                                CorrectAnswer = reader["CorrectAnswer"].ToString()
                            });
                        }
                    }


                }
            }
            return list;


        }
        //Just to call a certain question 
        public static Question GetQuestionById(int questionId)
        {
            using (var conn = DataBase.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Questions WHERE Id = @qid;";
                    cmd.Parameters.AddWithValue("@qid", questionId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Question
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ExamId = Convert.ToInt32(reader["ExamId"]),
                                QuestionText = reader["QuestionText"].ToString(),
                                QuestionType = reader["QuestionType"].ToString(),
                                CorrectAnswer = reader["CorrectAnswer"].ToString()
                            };
                        }
                    }
                }


            }
            return null;


        }

        public static bool DeleteQuestion(int questionId)
        {
            using (var conn = DataBase.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Questions WHERE Id = @qid;";
                    cmd.Parameters.AddWithValue("@qid", questionId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        } 
        public static bool UpdateQuestion(Question question)
        {
            using (var conn = DataBase.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
UPDATE Questions
   SET QuestionText  = @qText,
       QuestionType  = @qType,
       CorrectAnswer = @cAnswer
 WHERE Id = @qid;";
                    cmd.Parameters.AddWithValue("@qText", question.QuestionText);
                    cmd.Parameters.AddWithValue("@qType", question.QuestionType);
                    cmd.Parameters.AddWithValue("@cAnswer", question.CorrectAnswer ?? "");
                    cmd.Parameters.AddWithValue("@qid", question.Id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}
