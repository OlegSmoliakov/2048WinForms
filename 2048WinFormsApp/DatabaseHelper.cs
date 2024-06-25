using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TaskManager
{
    public class DatabaseHelper
    {
        private const string connectionString = "Data Source=leaderboard.db;Version=3;";

        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Leaderboard (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Score INTEGER
                )";
                SQLiteCommand createTable = new SQLiteCommand(createTableQuery, connection);
                createTable.ExecuteNonQuery();
            }
        }


        public static void CreateRecord(string name, int score)
        {
            DataRow row = ReadRecordByName(name);
            if (row != null) {
                int id = Convert.ToInt32(row["Id"]);
                int currentScore = Convert.ToInt32(row["Score"]);

                if (score <= currentScore) {
                    return;
                } 
                else {
                    UpdateRecord(id, score);
                    return;
                }
            }


            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                string insertCommand = "INSERT INTO Leaderboard (Name, Score) VALUES (@Name, @Score)";
                SQLiteCommand command = new SQLiteCommand(insertCommand, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Score", score);
                command.ExecuteNonQuery();
            }
        }

        public static DataTable ReadAllRecords()
        {
            DataTable dt = new DataTable();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectCommand = "SELECT Name, Score FROM Leaderboard ORDER BY Score DESC";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectCommand, connection);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static DataRow ReadRecordByName(string name)
        {   
            DataTable dt = new DataTable();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectCommand = "SELECT * FROM Leaderboard WHERE name = @Name";
                SQLiteCommand command = new SQLiteCommand(selectCommand, connection);
                command.Parameters.AddWithValue("@Name", name);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }

        public static int ReadBestScore()
        {
            DataTable dt = new DataTable();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectCommand = "SELECT MAX(Score) FROM Leaderboard";
                SQLiteCommand command = new SQLiteCommand(selectCommand, connection);
                object result = command.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToInt32(result);
                }
            }
            return 0;
        }


        public static void UpdateRecord(int id, int score)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateCommand = "UPDATE Leaderboard SET Score = @Score WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(updateCommand, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Score", score);
              
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteTask(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteCommand = "DELETE FROM Leaderboard WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(deleteCommand, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}