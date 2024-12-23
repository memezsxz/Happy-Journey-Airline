using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// This class provides an interface to interact with the stored payment methods in the database.
    /// It includes methods for retrieving, adding, updating, and deleting payment methods.
    /// </summary>
    public class PaymentMethod
    {
        /// <summary>
        /// Gets or sets the primary key of the payment method.
        /// </summary>
        public long Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the name of the payment method. This is nullable.
        /// </summary>
        public string Name { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the details of the payment method. This is nullable.
        /// </summary>
        public string Details { get; set; } // Nullable

        /// <summary>
        /// Returns a string representation of the PaymentMethod object.
        /// </summary>
        /// <returns>A string containing payment method details.</returns>
        public override string ToString()
        {
            return $"PaymentMethod [Id={Id}, Name={Name}, Details={Details}]";
        }

        /// <summary>
        /// Retrieves all payment methods from the database.
        /// </summary>
        /// <returns>A list of <see cref="PaymentMethod"/> objects.</returns>
        public static List<PaymentMethod> GetAllPaymentMethods()
        {
            string query = "SELECT Id, name, details FROM payment_methods";
            return Database.Instance.Query(query, reader => new PaymentMethod
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Details = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null
            });
        }

        /// <summary>
        /// Adds a new payment method to the database.
        /// </summary>
        /// <param name="paymentMethod">The <see cref="PaymentMethod"/> object to add.</param>
        /// <returns>The ID of the newly added payment method, or -1 if the operation failed.</returns>
        public static long AddPaymentMethod(PaymentMethod paymentMethod)
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

        /// <summary>
        /// Updates an existing payment method in the database.
        /// </summary>
        /// <param name="paymentMethod">The <see cref="PaymentMethod"/> object to update.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
        public static bool UpdatePaymentMethod(PaymentMethod paymentMethod)
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

        /// <summary>
        /// Deletes a payment method from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the payment method to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeletePaymentMethod(long id)
        {
            string query = "DELETE FROM payment_methods WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a payment method from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the payment method to retrieve.</param>
        /// <returns>A <see cref="PaymentMethod"/> object if found; otherwise, <c>null</c>.</returns>
        public static PaymentMethod GetPaymentMethodById(long id)
        {
            string query = "SELECT Id, name, details FROM payment_methods WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new PaymentMethod
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Details = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
