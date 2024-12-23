using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The PaymentStatus class provides an interface to interact with the stored payment statuses in the database.
    /// It includes methods for retrieving, adding, updating, and deleting payment statuses.
    /// </summary>
    public class PaymentStatus
    {
        /// <summary>
        /// Gets or sets the unique ID of the payment status (Primary Key).
        /// </summary>
        public int Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the name of the payment status (Nullable).
        /// </summary>
        public string Name { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the description of the payment status (Nullable).
        /// </summary>
        public string Description { get; set; } // Nullable

        /// <summary>
        /// Returns a string representation of the PaymentStatus object.
        /// </summary>
        /// <returns>A string containing payment status details.</returns>
        public override string ToString()
        {
            return $"PaymentStatus [Id={Id}, Name={Name}, Description={Description}]";
        }

        /// <summary>
        /// Retrieves all payment statuses from the database.
        /// </summary>
        /// <returns>A list of all payment statuses.</returns>
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

        /// <summary>
        /// Adds a new payment status to the database.
        /// </summary>
        /// <param name="paymentStatus">The payment status object containing status details.</param>
        /// <returns>The ID of the newly added payment status, or -1 if the operation failed.</returns>
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

        /// <summary>
        /// Updates an existing payment status in the database.
        /// </summary>
        /// <param name="paymentStatus">The payment status object containing updated status details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Deletes a payment status from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the payment status to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeletePaymentStatus(int id)
        {
            string query = "DELETE FROM payment_statuses WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a payment status from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the payment status to retrieve.</param>
        /// <returns>The payment status object if found; otherwise, <c>null</c>.</returns>
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
