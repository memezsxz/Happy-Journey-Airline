using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace HappyJourneyAirline.Lib
{
    public class Database
    {


        // Singleton instance
        private static Database _instance;

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        // Lock object for thread safety
        private static readonly object _lock = new object();

        // Connection string
        //public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30";
        //public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\202203193\Source\Repos\HappyJourneyAirline\HappyJourneyAirline\database.mdf;Integrated Security=True;";
        public static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\database.mdf;Integrated Security=True";
        //public static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ffoof\\OneDrive\\Documents\\New folder\\HappyJourneyAirline\\database.mdf\";Integrated Security=True";

        // Private constructor to prevent instantiation from outside
        private Database() {
            Connection = new SqlConnection(connectionString);
        }

        // Public static method to get the singleton instance
        public static Database Instance
        {
            get
            {
                // Ensure thread-safe initialization
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Database();
                        }
                    }
                }
                return _instance;
            }
        }

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }

        // Generic method to execute a query and return a list of results
        public List<T> Query<T>(string query, Func<SqlDataReader, T> map)
        {
            var results = new List<T>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            results.Add(map(reader));
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            return results;
        }

        public List<T> Query<T>(string query, Dictionary<string, object> parameters, Func<SqlDataReader, T> map)
        {
            var results = new List<T>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            results.Add(map(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            return results;
        }


        // Generic method to execute non-query commands (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }
                        return command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return -1;
                }
            }
        }
    }
}
