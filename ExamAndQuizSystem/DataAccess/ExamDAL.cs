using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamAndQuizSystem.Models;

namespace ExamAndQuizSystem.DataAccess
{
    public static class ExamDAL
    {
        public static bool AddExam(Exam exam)
        {
            using (var conn = DataBase.GetConnection()) {

                using (var cmd = conn.CreateCommand()) {

                    cmd.CommandText = @"
INSERT INTO Exams (Title, TeacherId, Date, Published)
VALUES (@title, @tid, @date, @published);";
                cmd.Parameters.AddWithValue("@title", exam.Title);
                cmd.Parameters.AddWithValue("@tid", exam.TeacherId);
                cmd.Parameters.AddWithValue("@date", exam.Date.ToString("s"));
                cmd.Parameters.AddWithValue("@published", exam.Published);
                    return cmd.ExecuteNonQuery() > 0;

                }                
            }
        }

        public static List<Exam> GetExamsByTeacher(int teacherId)
        {
            var list = new List<Exam>();
            using (var conn = DataBase.GetConnection())
            {
                using(var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Exams WHERE TeacherId = @tid;";
                    cmd.Parameters.AddWithValue("@tid", teacherId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                list.Add(new Exam
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Title = reader["Title"].ToString(),
                                    TeacherId = Convert.ToInt32(reader["TeacherId"]),
                                    Date = DateTime.Parse(reader["Date"].ToString()),
                                    Published = reader["Published"] != DBNull.Value ? Convert.ToBoolean(reader["Published"]) : false
                                });
                            }
                            catch (Exception ex)
                            {
                                // If Published column doesn't exist, default to false
                                list.Add(new Exam
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Title = reader["Title"].ToString(),
                                    TeacherId = Convert.ToInt32(reader["TeacherId"]),
                                    Date = DateTime.Parse(reader["Date"].ToString()),
                                    Published = false
                                });
                            }
                        }
                    }
                
                }
            }
            return list;
        }

        public static List<Exam> GetAllExams()
        {
            var list = new List<Exam>();
            using (var conn = DataBase.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Exams;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            list.Add(new Exam
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = reader["Title"].ToString(),
                                TeacherId = Convert.ToInt32(reader["TeacherId"]),
                                Date = DateTime.Parse(reader["Date"].ToString()),
                                Published = reader["Published"] != DBNull.Value ? Convert.ToBoolean(reader["Published"]) : false
                            });
                        }
                        catch (Exception ex)
                        {
                            // If Published column doesn't exist, default to false
                            list.Add(new Exam
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = reader["Title"].ToString(),
                                TeacherId = Convert.ToInt32(reader["TeacherId"]),
                                Date = DateTime.Parse(reader["Date"].ToString()),
                                Published = false
                            });
                        }
                    }
                }
            }
            return list;
        }

        public static List<Exam> GetPublishedExams()
        {
            var list = new List<Exam>();
            using (var conn = DataBase.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Exams WHERE Published = 1;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Exam
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Title = reader["Title"].ToString(),
                            TeacherId = Convert.ToInt32(reader["TeacherId"]),
                            Date = DateTime.Parse(reader["Date"].ToString()),
                            Published = Convert.ToBoolean(reader["Published"])
                        });
                    }
                }
            }
            return list;
        }

        public static bool UpdateExamPublished(int examId, bool published)
        {
            using (var conn = DataBase.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE Exams SET Published = @published WHERE Id = @examId;";
                cmd.Parameters.AddWithValue("@published", published);
                cmd.Parameters.AddWithValue("@examId", examId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static Exam GetExamById(int examId)
        {
            using (var conn = DataBase.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Exams WHERE Id = @examId;";
                cmd.Parameters.AddWithValue("@examId", examId);
                
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Exam
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Title = reader["Title"].ToString(),
                            TeacherId = Convert.ToInt32(reader["TeacherId"]),
                            Date = DateTime.Parse(reader["Date"].ToString()),
                            Published = Convert.ToBoolean(reader["Published"])
                        };
                    }
                }
            }
            return null;
        }
    }
}
