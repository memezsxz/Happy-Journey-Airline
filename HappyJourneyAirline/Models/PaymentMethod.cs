using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class PaymentMethod
    {
        public long Id { get; set; } // Primary Key
        public string Name { get; set; } // Nullable
        public string Details { get; set; } // Nullable

        // Fetch all payment methods
        public List<PaymentMethod> GetAllPaymentMethods()
        {
            string query = "SELECT Id, name, details FROM payment_methods";
            return Database.Instance.Query(query, reader => new PaymentMethod
            {
                Id = reader.GetInt64(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Details = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null
            });
        }

        // Add a new payment method
        public long AddPaymentMethod(PaymentMethod paymentMethod)
        {
            string query = @"
    INSERT INTO payment_methods (name, details)
    OUTPUT INSERTED.Id
    VALUES (@Name, @Details)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", (object)paymentMethod.Name ?? DBNull.Value },
                { "@Details", (object)paymentMethod.Details ?? DBNull.Value }
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
                        if (result != null && long.TryParse(result.ToString(), out long insertedId))
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

        // Update an existing payment method
        public bool UpdatePaymentMethod(PaymentMethod paymentMethod)
        {
            string query = @"
                UPDATE payment_methods
                SET name = @Name,
                    details = @Details
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", paymentMethod.Id },
                { "@Name", (object)paymentMethod.Name ?? DBNull.Value },
                { "@Details", (object)paymentMethod.Details ?? DBNull.Value }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a payment method
        public bool DeletePaymentMethod(long id)
        {
            string query = "DELETE FROM payment_methods WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a payment method by ID
        public PaymentMethod GetPaymentMethodById(long id)
        {
            string query = "SELECT Id, name, details FROM payment_methods WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new PaymentMethod
            {
                Id = reader.GetInt64(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Details = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
