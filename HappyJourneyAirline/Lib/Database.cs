using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace HappyJourneyAirline.Lib
{
    /// <summary>
    /// The Database class provides a singleton implementation for database operations.
    /// It includes methods for executing queries, non-queries, and backing up the database.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Singleton instance of the Database class.
        /// </summary>
        private static Database _instance;

        /// <summary>
        /// Lock object for thread-safe singleton initialization.
        /// </summary>
        private static readonly object _lock = new object();

        /// <summary>
        /// Connection string for the database.
        /// </summary>
        public static readonly string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\poly\\New folder\\HappyJourneyAirline\\database.mdf\";Integrated Security=True";

        /// <summary>
        /// Private constructor to prevent instantiation from outside the class.
        /// </summary>
        private Database() { }

        /// <summary>
        /// Provides the singleton instance of the Database class.
        /// Ensures thread-safe initialization.
        /// </summary>
        public static Database Instance
        {
            get
            {
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

        /// <summary>
        /// Executes a query and maps the results to a list of objects.
        /// </summary>
        /// <typeparam name="T">The type of objects to return.</typeparam>
        /// <param name="query">The SQL query string.</param>
        /// <param name="map">A function to map each SqlDataReader row to an object.</param>
        /// <returns>A list of mapped objects.</returns>
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

        /// <summary>
        /// Executes a query with parameters and maps the results to a list of objects.
        /// </summary>
        /// <typeparam name="T">The type of objects to return.</typeparam>
        /// <param name="query">The SQL query string.</param>
        /// <param name="parameters">A dictionary of query parameters.</param>
        /// <param name="map">A function to map each SqlDataReader row to an object.</param>
        /// <returns>A list of mapped objects.</returns>
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

        /// <summary>
        /// Backs up the database to a specified file path.
        /// </summary>
        /// <param name="backupFileName">The name of the backup file. Default is "HappyJourneyAirline_DB_Backup.bak".</param>
        /// <param name="backupPath">The directory path where the backup file will be saved. Defaults to the current directory.</param>
        /// <returns><c>true</c> if the backup was successful; otherwise, <c>false</c>.</returns>
        public static bool BackupDatabase(string backupFileName = "HappyJourneyAirline_DB_Backup.bak", string backupPath = null)
        {
            if (backupPath == null)
            {
                backupPath = AppDomain.CurrentDomain.BaseDirectory;
            }

            string backupFilePath = Path.Combine(backupPath, backupFileName);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string backupCommand = $"BACKUP DATABASE [{connection.Database}] TO DISK = @BackupFilePath";

                    using (SqlCommand command = new SqlCommand(backupCommand, connection))
                    {
                        command.Parameters.AddWithValue("@BackupFilePath", backupFilePath);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Database backed up successfully to: " + backupFilePath);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred during the backup process: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Executes a non-query SQL command (INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="query">The SQL query string.</param>
        /// <param name="parameters">A dictionary of query parameters.</param>
        /// <returns>The number of rows affected, or -1 if an error occurred.</returns>
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
