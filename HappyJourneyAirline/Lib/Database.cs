using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyAirline.Lib
{
    public  class Database
    {

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\202203193\source\repos\the0xahmed\HappyJourneyAirline\HappyJourneyAirline\database.mdf;Integrated Security=True";

        // Method to connect to the database and execute a simple query
        public void ConnectAndQuery()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();
                    Console.WriteLine("Connection established successfully.");

                    // Example query to fetch data (You can replace this with your own query)
                    string query = "SELECT * FROM USERS";  // Replace "YourTableName" with actual table name

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        // Reading the data (for demonstration, assuming we are printing it)
                        while (reader.Read())
                        {
                            Console.WriteLine("The username is :" + reader[1].ToString()); // Replace with the actual columns of your table
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    // The connection will be closed automatically by the 'using' block
                    Console.WriteLine("Connection closed.");
                }
            }
        }
    }
    
}
