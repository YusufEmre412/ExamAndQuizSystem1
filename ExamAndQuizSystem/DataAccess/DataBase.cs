using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace ExamAndQuizSystem.DataAccess
{
    public static class DataBase
    {
        private static readonly string dbFile = "exam.db"; //Database File
        private static readonly string connectionString = $"Data Source={dbFile};Version=3";

        public static void Initialize()
        {
            if (!File.Exists(dbFile)) //Checking if file exists, if not creating one.
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = @"
CREATE TABLE IF NOT EXISTS Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    FullName TEXT NOT NULL,
    Username TEXT NOT NULL UNIQUE,
    Password TEXT NOT NULL,
    Role TEXT NOT NULL 
                        );";
                    command.ExecuteNonQuery();

                    command.CommandText = @"
CREATE TABLE IF NOT EXISTS Exams(
    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
Title     TEXT    NOT NULL,
    TeacherId INTEGER NOT NULL,
    Date      TEXT    NOT NULL,
    Published INTEGER NOT NULL DEFAULT 0,
    FOREIGN KEY (TeacherId) REFERENCES Users(Id)

);";
                    command.ExecuteNonQuery();

                    // Add Published column to existing Exams table if it doesn't exist
                    try
                    {
                        // First check if the column exists
                        command.CommandText = "PRAGMA table_info(Exams);";
                        using (var reader = command.ExecuteReader())
                        {
                            bool columnExists = false;
                            while (reader.Read())
                            {
                                if (reader["name"].ToString() == "Published")
                                {
                                    columnExists = true;
                                    break;
                                }
                            }
                            
                            if (!columnExists)
                            {
                                // Close the reader before executing the ALTER command
                                reader.Close();
                                command.CommandText = "ALTER TABLE Exams ADD COLUMN Published INTEGER NOT NULL DEFAULT 0;";
                                command.ExecuteNonQuery();
                                Console.WriteLine("Successfully added Published column to Exams table");
                            }
                            else
                            {
                                Console.WriteLine("Published column already exists in Exams table");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error adding Published column: {ex.Message}");
                        // Continue anyway - the column might already exist
                    }

                command.CommandText = @"
CREATE TABLE IF NOT EXISTS Questions(
Id  INTEGER PRIMARY KEY AUTOINCREMENT,
ExamId  INTEGER NOT NULL,
QuestionText TEXT NOT NULL,
QuestionType TEXT NOT NULL, -- 'mcq' , 'fill' , 'code'
CorrectAnswer TEXT, -- Bosluk doldurma sorulari icin buraya kaydedilecek
FOREIGN KEY (ExamId) REFERENCES Exams(Id)
);";
                command.ExecuteNonQuery();

                command.CommandText = @"
CREATE TABLE IF NOT EXISTS Options(
Id  INTEGER PRIMARY KEY AUTOINCREMENT,
QuestionId INTEGER NOT NULL,
OptionText TEXT NOT NULL,
IsCorrect INTEGER NOT NULL, -- 0 VEYA 1
FOREIGN KEY (QuestionId) REFERENCES Questions(Id)
);";

                command.ExecuteNonQuery();

                command.CommandText = @"
CREATE TABLE IF NOT EXISTS Answers (
  Id          INTEGER PRIMARY KEY AUTOINCREMENT,
  StudentId   INTEGER NOT NULL,
  QuestionId  INTEGER NOT NULL,
  AnswerText  TEXT    NOT NULL,
  FOREIGN KEY (StudentId)  REFERENCES Users(Id),
  FOREIGN KEY (QuestionId) REFERENCES Questions(Id)
);";
                command.ExecuteNonQuery();

                command.CommandText = @"
CREATE TABLE IF NOT EXISTS Results (
    Id         INTEGER PRIMARY KEY AUTOINCREMENT,
    StudentId  INTEGER NOT NULL,
    ExamId     INTEGER NOT NULL,
    Score      INTEGER NOT NULL,
    TakenDate  TEXT    NOT NULL,
    FOREIGN KEY (StudentId) REFERENCES Users(Id),
    FOREIGN KEY (ExamId)    REFERENCES Exams(Id)
);";
                command.ExecuteNonQuery();

                command.CommandText = @"
CREATE TABLE IF NOT EXISTS Messages (
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    SenderId    INTEGER NOT NULL,
    ReceiverId  INTEGER NOT NULL,
    MessageText TEXT    NOT NULL,
    SentTime    TEXT    NOT NULL,
    IsRead      INTEGER NOT NULL DEFAULT 0,
    FOREIGN KEY (SenderId)   REFERENCES Users(Id),
    FOREIGN KEY (ReceiverId) REFERENCES Users(Id)
);";
                command.ExecuteNonQuery();


            }
            

        }
        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;

        }



    }
}
