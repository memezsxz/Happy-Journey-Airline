
// Ticket  Provide an interface to interact with stored tickets

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class Ticket
    {
        // Ticket Attributes
        public int Id { get; set; } // Primary Key
        public int FlightID { get; set; } // Foreign Key (Flight)
        public long UserID { get; set; } // Foreign Key (User)
        public string Seat { get; set; } // NOT NULL
        public int TicketClassID { get; set; } // Foreign Key (Ticket Class)
        public int TicketStatusID { get; set; } // Foreign Key (Ticket Status)
        public int PaymentID { get; set; } // Foreign Key (Payment)
        public long? AgencyID { get; set; } // Nullable Foreign Key (Agency)

        // Fetch all tickets
        public static List<Ticket> GetAllTickets()
        {
            string query = @"
                SELECT Id, flightID, userID, seat, ticketClassID, ticketStatusID, paymentID, agencyID 
                FROM tickets";
            return Database.Instance.Query(query, reader => new Ticket
            {
                Id = reader.GetInt32(0),
                FlightID = reader.GetInt32(1),
                UserID = reader.GetInt64(2),
                Seat = reader.GetString(3),
                TicketClassID = reader.GetInt32(4),
                TicketStatusID = reader.GetInt32(5),
                PaymentID = reader.GetInt32(6),
                AgencyID = !reader.IsDBNull(7) ? reader.GetInt64(7) : (long?)null
            });
        }

        // Add a new ticket
        public static int AddTicket(Ticket ticket)
        {
            string query = @"
    INSERT INTO tickets (flightID, userID, seat, ticketClassID, ticketStatusID, paymentID, agencyID)
    OUTPUT INSERTED.Id
    VALUES (@FlightID, @UserID, @Seat, @TicketClassID, @TicketStatusID, @PaymentID, @AgencyID)";
            var parameters = new Dictionary<string, object>
            {
                { "@FlightID", ticket.FlightID },
                { "@UserID", ticket.UserID },
                { "@Seat", ticket.Seat },
                { "@TicketClassID", ticket.TicketClassID },
                { "@TicketStatusID", ticket.TicketStatusID },
                { "@PaymentID", ticket.PaymentID },
                { "@AgencyID", (object)ticket.AgencyID ?? DBNull.Value }
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

        // Update an existing ticket
        public static bool UpdateTicket(Ticket ticket)
        {
            string query = @"
                UPDATE tickets
                SET flightID = @FlightID,
                    userID = @UserID,
                    seat = @Seat,
                    ticketClassID = @TicketClassID,
                    ticketStatusID = @TicketStatusID,
                    paymentID = @PaymentID,
                    agencyID = @AgencyID
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", ticket.Id },
                { "@FlightID", ticket.FlightID },
                { "@UserID", ticket.UserID },
                { "@Seat", ticket.Seat },
                { "@TicketClassID", ticket.TicketClassID },
                { "@TicketStatusID", ticket.TicketStatusID },
                { "@PaymentID", ticket.PaymentID },
                { "@AgencyID", (object)ticket.AgencyID ?? DBNull.Value }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a ticket
        public static bool DeleteTicket(int id)
        {
            string query = "DELETE FROM tickets WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a ticket by ID
        public static Ticket GetTicketById(int id)
        {
            string query = @"
                SELECT Id, flightID, userID, seat, ticketClassID, ticketStatusID, paymentID, agencyID 
                FROM tickets 
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new Ticket
            {
                Id = reader.GetInt32(0),
                FlightID = reader.GetInt32(1),
                UserID = reader.GetInt64(2),
                Seat = reader.GetString(3),
                TicketClassID = reader.GetInt32(4),
                TicketStatusID = reader.GetInt32(5),
                PaymentID = reader.GetInt32(6),
                AgencyID = !reader.IsDBNull(7) ? reader.GetInt64(7) : (long?)null
            });
            return result.Count > 0 ? result[0] : null;
        }


        // Fetch all tickets by the user id 
        public static List<Ticket> GetTicketsByUserId(int userId)
        {
            string query = @"
                SELECT Id, flightID, userID, seat, ticketClassID, ticketStatusID, paymentID, agencyID 
                FROM tickets 
                WHERE userID = @userID";
            var parameters = new Dictionary<string, object>
            {
                { "@userId", userId }
            };
            return Database.Instance.Query(query, parameters, reader => new Ticket
            {
                Id = reader.GetInt32(0),
                FlightID = reader.GetInt32(1),
                UserID = reader.GetInt64(2),
                Seat = reader.GetString(3),
                TicketClassID = reader.GetInt32(4),
                TicketStatusID = reader.GetInt32(5),
                PaymentID = reader.GetInt32(6),
                AgencyID = !reader.IsDBNull(7) ? reader.GetInt64(7) : (long?)null
            });
        }
        // Fetch all tickets for a specific flight
        public static List<Ticket> GetTicketsByFlightId(long flightId)
        {
            string query = @"
                SELECT Id, flightID, userID, seat, ticketClassID, ticketStatusID, paymentID, agencyID 
                FROM tickets 
                WHERE flightID = @FlightID";
            var parameters = new Dictionary<string, object>
            {
                { "@FlightID", flightId }
            };
            return Database.Instance.Query(query, parameters, reader => new Ticket
            {
                Id = reader.GetInt32(0),
                FlightID = reader.GetInt32(1),
                UserID = reader.GetInt64(2),
                Seat = reader.GetString(3),
                TicketClassID = reader.GetInt32(4),
                TicketStatusID = reader.GetInt32(5),
                PaymentID = reader.GetInt32(6),
                AgencyID = !reader.IsDBNull(7) ? reader.GetInt64(7) : (long?)null
            });
        }
    }
}
