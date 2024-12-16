using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class TicketStatus
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Nullable
        public string Description { get; set; } // Nullable

        // Fetch all ticket statuses
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

        // Add a new ticket status
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

        // Update an existing ticket status
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

        // Delete a ticket status
        public static bool DeleteTicketStatus(int id)
        {
            string query = "DELETE FROM ticket_statuses WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a ticket status by ID
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
