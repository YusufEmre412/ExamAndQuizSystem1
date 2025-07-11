using System;
using System.Collections.Generic;
using System.Linq;
using ExamAndQuizSystem.Models;

namespace ExamAndQuizSystem.DataAccess
{
    public static class MessageDAL
    {
        public static bool AddMessage(Message message)
        {
            using (var conn = DataBase.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
INSERT INTO Messages (SenderId, ReceiverId, MessageText, SentTime, IsRead)
VALUES (@senderId, @receiverId, @messageText, @sentTime, @isRead);";
                
                cmd.Parameters.AddWithValue("@senderId", message.SenderId);
                cmd.Parameters.AddWithValue("@receiverId", message.ReceiverId);
                cmd.Parameters.AddWithValue("@messageText", message.MessageText);
                cmd.Parameters.AddWithValue("@sentTime", message.SentTime.ToString("s"));
                cmd.Parameters.AddWithValue("@isRead", message.IsRead);
                
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static List<Message> GetConversation(int user1Id, int user2Id)
        {
            var list = new List<Message>();
            using (var conn = DataBase.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
SELECT * FROM Messages 
WHERE (SenderId = @user1Id AND ReceiverId = @user2Id) 
   OR (SenderId = @user2Id AND ReceiverId = @user1Id)
ORDER BY SentTime ASC;";
                
                cmd.Parameters.AddWithValue("@user1Id", user1Id);
                cmd.Parameters.AddWithValue("@user2Id", user2Id);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Message
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            SenderId = Convert.ToInt32(reader["SenderId"]),
                            ReceiverId = Convert.ToInt32(reader["ReceiverId"]),
                            MessageText = reader["MessageText"].ToString(),
                            SentTime = DateTime.Parse(reader["SentTime"].ToString()),
                            IsRead = Convert.ToBoolean(reader["IsRead"])
                        });
                    }
                }
            }
            return list;
        }

        public static List<Message> GetUnreadMessages(int userId)
        {
            var list = new List<Message>();
            using (var conn = DataBase.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Messages WHERE ReceiverId = @userId AND IsRead = 0 ORDER BY SentTime DESC;";
                cmd.Parameters.AddWithValue("@userId", userId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Message
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            SenderId = Convert.ToInt32(reader["SenderId"]),
                            ReceiverId = Convert.ToInt32(reader["ReceiverId"]),
                            MessageText = reader["MessageText"].ToString(),
                            SentTime = DateTime.Parse(reader["SentTime"].ToString()),
                            IsRead = Convert.ToBoolean(reader["IsRead"])
                        });
                    }
                }
            }
            return list;
        }

        public static bool MarkAsRead(int messageId)
        {
            using (var conn = DataBase.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE Messages SET IsRead = 1 WHERE Id = @messageId;";
                cmd.Parameters.AddWithValue("@messageId", messageId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static List<Users> GetContactList(int userId)
        {
            var contacts = new List<Users>();
            using (var conn = DataBase.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                // Get all users except the current user
                cmd.CommandText = "SELECT * FROM Users WHERE Id != @userId ORDER BY FullName;";
                cmd.Parameters.AddWithValue("@userId", userId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contacts.Add(new Users
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FullName = reader["FullName"].ToString(),
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString()
                        });
                    }
                }
            }
            return contacts;
        }
    }
}
