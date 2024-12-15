using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class PaymentStatus
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Nullable
        public string Description { get; set; } // Nullable

        // Fetch all payment statuses
        public static List<PaymentStatus> GetAllPaymentStatuses()
        {
            string query = "SELECT Id, name, description FROM payment_statuses";
            return Database.Instance.Query(query, reader => new PaymentStatus
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Description = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null
            });
        }

        // Add a new payment status
        public static int AddPaymentStatus(PaymentStatus paymentStatus)
        {
            string query = @"
    INSERT INTO payment_statuses (name, description)
    OUTPUT INSERTED.Id
    VALUES (@Name, @Description)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", (object)paymentStatus.Name ?? DBNull.Value },
                { "@Description", (object)paymentStatus.Description ?? DBNull.Value }
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

        // Update an existing payment status
        public static bool UpdatePaymentStatus(PaymentStatus paymentStatus)
        {
            string query = @"
                UPDATE payment_statuses
                SET name = @Name,
                    description = @Description
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", paymentStatus.Id },
                { "@Name", (object)paymentStatus.Name ?? DBNull.Value },
                { "@Description", (object)paymentStatus.Description ?? DBNull.Value }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a payment status
        public static bool DeletePaymentStatus(int id)
        {
            string query = "DELETE FROM payment_statuses WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a payment status by ID
        public static PaymentStatus GetPaymentStatusById(int id)
        {
            string query = "SELECT Id, name, description FROM payment_statuses WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new PaymentStatus
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Description = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
