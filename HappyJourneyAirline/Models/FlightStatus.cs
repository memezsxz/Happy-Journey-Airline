using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class FlightStatus
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // NOT NULL
        public string Description { get; set; } // NOT NULL

        // Fetch all flight statuses
        public List<FlightStatus> GetAllFlightStatuses()
        {
            string query = "SELECT Id, name, description FROM flight_statuses";
            return Database.Instance.Query(query, reader => new FlightStatus
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1).Trim(),
                Description = reader.GetString(2).Trim()
            });
        }

        // Add a new flight status
        public int AddFlightStatus(FlightStatus flightStatus)
        {
            string query = @"
    INSERT INTO flight_statuses (name, description)
    OUTPUT INSERTED.Id
    VALUES (@Name, @Description)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", flightStatus.Name },
                { "@Description", flightStatus.Description }
            };

            using (SqlConnection connection = new SqlConnection(Database.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        // Execute the query and return the inserted ID
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedId))
                        {
                            return insertedId;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            return -1; // Return -1 if the insertion failed
        }

        // Update an existing flight status
        public bool UpdateFlightStatus(FlightStatus flightStatus)
        {
            string query = @"
                UPDATE flight_statuses
                SET name = @Name,
                    description = @Description
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", flightStatus.Id },
                { "@Name", flightStatus.Name },
                { "@Description", flightStatus.Description }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a flight status
        public bool DeleteFlightStatus(int id)
        {
            string query = "DELETE FROM flight_statuses WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a flight status by ID
        public FlightStatus GetFlightStatusById(int id)
        {
            string query = "SELECT Id, name, description FROM flight_statuses WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new FlightStatus
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1).Trim(),
                Description = reader.GetString(2).Trim()
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
