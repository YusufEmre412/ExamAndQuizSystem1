using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using ExamAndQuizSystem.Models; 

namespace ExamAndQuizSystem.DataAccess
{
    class UserDAL // Adds a user, gets a user by username and password
    {
        public static bool AddUser(Users user)
        {
            using (var connection = DataBase.GetConnection()){
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Users (FullName, Username, Password, Role) VALUES (@fullName, @username, @password, @role)";
                command.Parameters.AddWithValue("@fullName", user.FullName);
                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@role", user.Role);

                return command.ExecuteNonQuery() > 0;

            }

        }

        public static Users GetUser(string Username, string Password)
        {
            using (var connection = DataBase.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                command.Parameters.AddWithValue("@username", Username);
                command.Parameters.AddWithValue("@password", Password);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Users
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FullName = reader["FullName"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }


                }

            }
            return null;

        }
        public static List<Users> GetAllUsers()
        {
            var list = new List<Users>();
            using (var conn = DataBase.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users;";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Users
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                FullName = reader["FullName"].ToString(),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }
        public static Users GetById(int id)
        {
            using (var conn = DataBase.GetConnection()) { 
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Users WHERE Id=@id;";
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Users
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FullName = reader["FullName"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }
                }
            }
            }
            return null;
        }

    }
}
