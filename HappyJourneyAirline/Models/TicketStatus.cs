using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The TicketStatus class provides an interface to interact with the stored ticket statuses in the database.
    /// It includes methods for retrieving, adding, updating, and deleting ticket statuses.
    /// </summary>
    public class TicketStatus
    {
        /// <summary>
        /// Gets or sets the unique ID of the ticket status (Primary Key).
        /// </summary>
        public int Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the name of the ticket status (Nullable).
        /// </summary>
        public string Name { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the description of the ticket status (Nullable).
        /// </summary>
        public string Description { get; set; } // Nullable

        /// <summary>
        /// Retrieves all ticket statuses from the database.
        /// </summary>
        /// <returns>A list of all ticket statuses.</returns>
        public static List<TicketStatus> GetAllTicketStatuses()
        {
            string query = "SELECT Id, name, description FROM ticket_statuses";
            return Database.Instance.Query(query, reader => new TicketStatus
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Description = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null
            });
        }

        /// <summary>
        /// Adds a new ticket status to the database.
        /// </summary>
        /// <param name="ticketStatus">The ticket status object containing status details.</param>
        /// <returns>The ID of the newly added ticket status, or -1 if the operation failed.</returns>
        public static int AddTicketStatus(TicketStatus ticketStatus)
        {
            string query = @"
    INSERT INTO ticket_statuses (name, description)
    OUTPUT INSERTED.Id
    VALUES (@Name, @Description)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", (object)ticketStatus.Name ?? DBNull.Value },
                { "@Description", (object)ticketStatus.Description ?? DBNull.Value }
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
        /// Updates an existing ticket status in the database.
        /// </summary>
        /// <param name="ticketStatus">The ticket status object containing updated status details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
        public static bool UpdateTicketStatus(TicketStatus ticketStatus)
        {
            string query = @"
                UPDATE ticket_statuses
                SET name = @Name,
                    description = @Description
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", ticketStatus.Id },
                { "@Name", (object)ticketStatus.Name ?? DBNull.Value },
                { "@Description", (object)ticketStatus.Description ?? DBNull.Value }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Deletes a ticket status from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the ticket status to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeleteTicketStatus(int id)
        {
            string query = "DELETE FROM ticket_statuses WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a ticket status from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the ticket status to retrieve.</param>
        /// <returns>The ticket status object if found; otherwise, <c>null</c>.</returns>
        public static TicketStatus GetTicketStatusById(int id)
        {
            string query = "SELECT Id, name, description FROM ticket_statuses WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new TicketStatus
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Description = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
