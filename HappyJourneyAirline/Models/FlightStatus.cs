using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The FlightStatus class provides an interface to interact with the stored flight statuses in the database.
    /// It includes methods for retrieving, adding, updating, and deleting flight statuses.
    /// </summary>
    public class FlightStatus
    {
        /// <summary>
        /// Gets or sets the unique ID of the flight status (Primary Key).
        /// </summary>
        public int Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the name of the flight status (Required).
        /// </summary>
        public string Name { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the description of the flight status (Required).
        /// </summary>
        public string Description { get; set; } // NOT NULL

        /// <summary>
        /// Retrieves all flight statuses from the database.
        /// </summary>
        /// <returns>A list of all flight statuses.</returns>
        public static List<FlightStatus> GetAllFlightStatuses()
        {
            string query = "SELECT Id, name, description FROM flight_statuses";
            return Database.Instance.Query(query, reader => new FlightStatus
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1).Trim(),
                Description = reader.GetString(2).Trim()
            });
        }

        /// <summary>
        /// Adds a new flight status to the database.
        /// </summary>
        /// <param name="flightStatus">The flight status object containing status details.</param>
        /// <returns>The ID of the newly added flight status, or -1 if the operation failed.</returns>
        public static int AddFlightStatus(FlightStatus flightStatus)
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

        /// <summary>
        /// Updates an existing flight status in the database.
        /// </summary>
        /// <param name="flightStatus">The flight status object containing updated status details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
        public static bool UpdateFlightStatus(FlightStatus flightStatus)
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

        /// <summary>
        /// Deletes a flight status from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the flight status to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeleteFlightStatus(int id)
        {
            string query = "DELETE FROM flight_statuses WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a flight status from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the flight status to retrieve.</param>
        /// <returns>The flight status object if found; otherwise, <c>null</c>.</returns>
        public static FlightStatus GetFlightStatusById(int id)
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
