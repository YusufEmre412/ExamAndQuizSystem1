using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using ExamAndQuizSystem.Models;

namespace ExamAndQuizSystem.DataAccess
{
    public static class ResultDAL
    {
        public static bool AddResult(Result result)
        {
            using (var conn = DataBase.GetConnection()) { 
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
INSERT INTO Results (StudentId, ExamId, Score, TakenDate)
VALUES (@sid, @eid, @score, @date);";
                cmd.Parameters.AddWithValue("@sid", result.StudentId);
                cmd.Parameters.AddWithValue("@eid", result.ExamId);
                cmd.Parameters.AddWithValue("@score", result.Score);
                cmd.Parameters.AddWithValue("@date", result.TakenDate.ToString("s"));
                return cmd.ExecuteNonQuery() > 0;
            }
            }
        }

        public static List<Result> GetResultsByStudent(int studentId)
        {
            var list = new List<Result>();
            using (var conn = DataBase.GetConnection()) { 
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
SELECT * FROM Results
 WHERE StudentId = @sid
 ORDER BY TakenDate DESC;";
                cmd.Parameters.AddWithValue("@sid", studentId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Result
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            StudentId = Convert.ToInt32(reader["StudentId"]),
                            ExamId = Convert.ToInt32(reader["ExamId"]),
                            Score = Convert.ToInt32(reader["Score"]),
                            TakenDate = DateTime.Parse(reader["TakenDate"].ToString())
                        });
                    }
                }
            }
            }
            return list;
        }
        public static List<Result> GetResultsByExam(int examId)
        {
            var list = new List<Result>();
            using (var conn = DataBase.GetConnection()) {     
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Results WHERE ExamId=@eid;";
                cmd.Parameters.AddWithValue("@eid", examId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Result
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            StudentId = Convert.ToInt32(reader["StudentId"]),
                            ExamId = Convert.ToInt32(reader["ExamId"]),
                            Score = Convert.ToInt32(reader["Score"]),
                            TakenDate = DateTime.Parse(reader["TakenDate"].ToString())
                        });
                    }
                }
            }
            }
            return list;
        }

    }
}
