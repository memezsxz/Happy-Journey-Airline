using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace HappyJourneyAirline.Lib
{
    public class Database
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True";

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