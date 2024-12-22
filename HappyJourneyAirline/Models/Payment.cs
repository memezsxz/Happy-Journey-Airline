using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The Payment class provides an interface to interact with the stored payments in the database.
    /// It includes methods for retrieving, adding, updating, and deleting payments, as well as filtering payments by status.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Gets or sets the unique ID of the payment (Primary Key).
        /// </summary>
        public int Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the amount of the payment (Required).
        /// </summary>
        public decimal Amount { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the date of the payment (Required).
        /// </summary>
        public DateTime Date { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the payment status ID (Foreign Key).
        /// </summary>
        public int PaymentStatusID { get; set; } // Foreign Key

        /// <summary>
        /// Gets or sets the payment method ID (Foreign Key).
        /// </summary>
        public int PaymentMethodID { get; set; } // Foreign Key

        /// <summary>
        /// Retrieves all payments from the database.
        /// </summary>
        /// <returns>A list of all payments.</returns>
        public static List<Payment> GetAllPayments()
        {
            string query = "SELECT Id, amount, date, paymentStatusID, paymentMethodID FROM payments";
            return Database.Instance.Query(query, reader => new Payment
            {
                Id = reader.GetInt32(0),
                Amount = reader.GetDecimal(1),
                Date = reader.GetDateTime(2),
                PaymentStatusID = reader.GetInt32(3),
                PaymentMethodID = reader.GetInt32(4)
            });
        }

        /// <summary>
        /// Adds a new payment to the database.
        /// </summary>
        /// <param name="payment">The payment object containing payment details.</param>
        /// <returns>The ID of the newly added payment, or -1 if the operation failed.</returns>
        public static int AddPayment(Payment payment)
        {
            string query = @"
    INSERT INTO payments (amount, date, paymentStatusID, paymentMethodID)
    OUTPUT INSERTED.Id
    VALUES (@Amount, @Date, @PaymentStatusID, @PaymentMethodID)";
            var parameters = new Dictionary<string, object>
            {
                { "@Amount", payment.Amount },
                { "@Date", payment.Date },
                { "@PaymentStatusID", payment.PaymentStatusID },
                { "@PaymentMethodID", payment.PaymentMethodID }
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
        /// Updates an existing payment in the database.
        /// </summary>
        /// <param name="payment">The payment object containing updated payment details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
        public static bool UpdatePayment(Payment payment)
        {
            string query = @"
                UPDATE payments
                SET amount = @Amount,
                    date = @Date,
                    paymentStatusID = @PaymentStatusID,
                    paymentMethodID = @PaymentMethodID
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", payment.Id },
                { "@Amount", payment.Amount },
                { "@Date", payment.Date },
                { "@PaymentStatusID", payment.PaymentStatusID },
                { "@PaymentMethodID", payment.PaymentMethodID }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Deletes a payment from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the payment to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeletePayment(int id)
        {
            string query = "DELETE FROM payments WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a payment from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the payment to retrieve.</param>
        /// <returns>The payment object if found; otherwise, <c>null</c>.</returns>
        public static Payment GetPaymentById(int id)
        {
            string query = "SELECT Id, amount, date, paymentStatusID, paymentMethodID FROM payments WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new Payment
            {
                Id = reader.GetInt32(0),
                Amount = reader.GetDecimal(1),
                Date = reader.GetDateTime(2),
                PaymentStatusID = reader.GetInt32(3),
                PaymentMethodID = reader.GetInt32(4)
            });
            return result.Count > 0 ? result[0] : null;
        }

        /// <summary>
        /// Retrieves all payments with a specific payment status ID.
        /// </summary>
        /// <param name="paymentStatusId">The ID of the payment status.</param>
        /// <returns>A list of payments with the specified payment status.</returns>
        public static List<Payment> GetPaymentsByStatusId(int paymentStatusId)
        {
            string query = "SELECT Id, amount, date, paymentStatusID, paymentMethodID FROM payments WHERE paymentStatusID = @PaymentStatusID";
            var parameters = new Dictionary<string, object>
            {
                { "@PaymentStatusID", paymentStatusId }
            };
            return Database.Instance.Query(query, parameters, reader => new Payment
            {
                Id = reader.GetInt32(0),
                Amount = reader.GetDecimal(1),
                Date = reader.GetDateTime(2),
                PaymentStatusID = reader.GetInt32(3),
                PaymentMethodID = reader.GetInt32(4)
            });
        }
    }
}
