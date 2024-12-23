using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The TicketClass class provides an interface to interact with the stored ticket classes in the database.
    /// It includes methods for retrieving, adding, updating, and deleting ticket classes.
    /// </summary>
    public class TicketClass
    {
        /// <summary>
        /// Gets or sets the unique ID of the ticket class (Primary Key).
        /// </summary>
        public int Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the name of the ticket class (Nullable).
        /// </summary>
        public string Name { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the description of the ticket class (Nullable).
        /// </summary>
        public string Description { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the services offered in the ticket class (Nullable).
        /// </summary>
        public string Services { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the extra price associated with the ticket class. Default value is 0.00.
        /// </summary>
        public decimal ExtraPrice { get; set; } // Default to 0.00

        /// <summary>
        /// Retrieves all ticket classes from the database.
        /// </summary>
        /// <returns>A list of all ticket classes.</returns>
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

        /// <summary>
        /// Adds a new ticket class to the database.
        /// </summary>
        /// <param name="ticketClass">The ticket class object containing class details.</param>
        /// <returns>The ID of the newly added ticket class, or -1 if the operation failed.</returns>
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

        /// <summary>
        /// Updates an existing ticket class in the database.
        /// </summary>
        /// <param name="ticketClass">The ticket class object containing updated class details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Deletes a ticket class from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the ticket class to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeleteTicketClass(int id)
        {
            string query = "DELETE FROM ticket_classes WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a ticket class from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the ticket class to retrieve.</param>
        /// <returns>The ticket class object if found; otherwise, <c>null</c>.</returns>
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
