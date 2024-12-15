using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class Payment
    {
        public int Id { get; set; } // Primary Key
        public decimal Amount { get; set; } // NOT NULL
        public DateTime Date { get; set; } // NOT NULL
        public int PaymentStatusID { get; set; } // Foreign Key
        public int PaymentMethodID { get; set; } // Foreign Key

        // Fetch all payments
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

        // Add a new payment
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

        // Update an existing payment
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

        // Delete a payment
        public static bool DeletePayment(int id)
        {
            string query = "DELETE FROM payments WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a payment by ID
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

        // Fetch all payments for a specific payment status
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
