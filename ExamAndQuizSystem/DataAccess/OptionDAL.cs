using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamAndQuizSystem.Models;

namespace ExamAndQuizSystem.DataAccess
{
    public static class OptionDAL
    {
        // Add an option for multiple choice questions
        public static bool AddOption(Option option)
        {
            using (var conn = DataBase.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
INSERT INTO Options (QuestionId, OptionText, IsCorrect)
VALUES (@qid, @oText, @isCorrect);";
                    cmd.Parameters.AddWithValue("@qid", option.QuestionId);
                    cmd.Parameters.AddWithValue("@oText", option.OptionText);
                    cmd.Parameters.AddWithValue("@isCorrect", option.IsCorrect ? 1 : 0);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static List<Option> GetOptionsByQuestion(int questionId)
        {
            var list = new List<Option>();

            using (var conn = DataBase.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Options WHERE QuestionId = @qid;";
                    cmd.Parameters.AddWithValue("@qid", questionId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Option
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                QuestionId = Convert.ToInt32(reader["QuestionId"]),
                                OptionText = reader["OptionText"].ToString(),
                                IsCorrect = Convert.ToInt32(reader["IsCorrect"]) == 1
                            });
                        }

                    }
                }


            }
            return list;
        }
    
        //Delete only one option
        public static bool DeleteOption(int optionId)
        {
            using (var conn = DataBase.GetConnection())
            {
                using(var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Options WHERE Id = @oid;";
                    cmd.Parameters.AddWithValue("@oid", optionId);
                    return cmd.ExecuteNonQuery() > 0;

                }
            }
        }
        //Delete all options of a question (for example when deleting a question)
        public static bool DeleteOptionsByQuestion(int questionId)
        {
            using(var conn = DataBase.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Options WHERE QuestionId = @qid;";
                    cmd.Parameters.AddWithValue("@qid", questionId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }
    }


}
