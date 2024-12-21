// Ticket Class Provide an interface to interact with stored ticket classes
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class TicketClass
    {
        // Ticket Class Attributes
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Nullable
        public string Description { get; set; } // Nullable
        public string Services { get; set; } // Nullable
        public decimal ExtraPrice { get; set; } // Default to 0.00

        // Fetch all ticket classes
        public static List<TicketClass> GetAllTicketClasses()
        {
            string query = "SELECT Id, name, description, services, extraPrice FROM ticket_classes";
            return Database.Instance.Query(query, reader => new TicketClass
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Description = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null,
                Services = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : null,
                ExtraPrice = reader.GetDecimal(4)
            });
        }

        // Add a new ticket class
        public static int AddTicketClass(TicketClass ticketClass)
        {
            string query = @"
    INSERT INTO ticket_classes (name, description, services, extraPrice)
    OUTPUT INSERTED.Id
    VALUES (@Name, @Description, @Services, @ExtraPrice)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", (object)ticketClass.Name ?? DBNull.Value },
                { "@Description", (object)ticketClass.Description ?? DBNull.Value },
                { "@Services", (object)ticketClass.Services ?? DBNull.Value },
                { "@ExtraPrice", ticketClass.ExtraPrice }
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

        // Update an existing ticket class
        public static bool UpdateTicketClass(TicketClass ticketClass)
        {
            string query = @"
                UPDATE ticket_classes
                SET name = @Name,
                    description = @Description,
                    services = @Services,
                    extraPrice = @ExtraPrice
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", ticketClass.Id },
                { "@Name", (object)ticketClass.Name ?? DBNull.Value },
                { "@Description", (object)ticketClass.Description ?? DBNull.Value },
                { "@Services", (object)ticketClass.Services ?? DBNull.Value },
                { "@ExtraPrice", ticketClass.ExtraPrice }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a ticket class
        public static bool DeleteTicketClass(int id)
        {
            string query = "DELETE FROM ticket_classes WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a ticket class by ID
        public static TicketClass GetTicketClassById(int id)
        {
            string query = "SELECT Id, name, description, services, extraPrice FROM ticket_classes WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new TicketClass
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Description = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null,
                Services = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : null,
                ExtraPrice = reader.GetDecimal(4)
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
