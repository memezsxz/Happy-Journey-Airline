using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The Ticket class provides an interface to interact with the stored tickets in the database.
    /// It includes methods for retrieving, adding, updating, deleting tickets, and fetching tickets by user or flight ID.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Gets or sets the unique ID of the ticket (Primary Key).
        /// </summary>
        public int Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the flight ID associated with the ticket (Foreign Key).
        /// </summary>
        public int FlightID { get; set; } // Foreign Key (Flight)

        /// <summary>
        /// Gets or sets the user ID associated with the ticket (Foreign Key).
        /// </summary>
        public long UserID { get; set; } // Foreign Key (User)

        /// <summary>
        /// Gets or sets the seat assigned to the ticket (Required).
        /// </summary>
        public string Seat { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the ticket class ID (Foreign Key).
        /// </summary>
        public int TicketClassID { get; set; } // Foreign Key (Ticket Class)

        /// <summary>
        /// Gets or sets the ticket status ID (Foreign Key).
        /// </summary>
        public int TicketStatusID { get; set; } // Foreign Key (Ticket Status)

        /// <summary>
        /// Gets or sets the payment ID associated with the ticket (Foreign Key).
        /// </summary>
        public int PaymentID { get; set; } // Foreign Key (Payment)

        /// <summary>
        /// Gets or sets the agency ID associated with the ticket (Nullable Foreign Key).
        /// </summary>
        public long? AgencyID { get; set; } // Nullable Foreign Key (Agency)


        /// <summary>
        /// Returns a string representation of the Ticket object.
        /// </summary>
        /// <returns>A string containing ticket details.</returns>
        public override string ToString()
        {
            return $"Ticket [Id={Id}, FlightID={FlightID}, UserID={UserID}, Seat={Seat}, TicketClassID={TicketClassID}, TicketStatusID={TicketStatusID}, PaymentID={PaymentID}, AgencyID={(AgencyID.HasValue ? AgencyID.ToString() : "None")}]";
        }

        /// <summary>
        /// Retrieves all tickets from the database.
        /// </summary>
        /// <returns>A list of all tickets.</returns>
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

        /// <summary>
        /// Adds a new ticket to the database.
        /// </summary>
        /// <param name="ticket">The ticket object containing ticket details.</param>
        /// <returns>The ID of the newly added ticket, or -1 if the operation failed.</returns>
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

        /// <summary>
        /// Updates an existing ticket in the database.
        /// </summary>
        /// <param name="ticket">The ticket object containing updated ticket details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Deletes a ticket from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the ticket to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeleteTicket(int id)
        {
            string query = "DELETE FROM tickets WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a ticket from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the ticket to retrieve.</param>
        /// <returns>The ticket object if found; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Retrieves all tickets associated with a specific user by their user ID.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>A list of tickets associated with the user.</returns>
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

        /// <summary>
        /// Retrieves all tickets associated with a specific flight by flight ID.
        /// </summary>
        /// <param name="flightId">The ID of the flight.</param>
        /// <returns>A list of tickets associated with the flight.</returns>
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

        public static Ticket GetTicketByFlightAndUserID(long flightId, long userId)
        {
            string query = @"
                SELECT Id, flightID, userID, seat, ticketClassID, ticketStatusID, paymentID, agencyID 
                FROM tickets 
                WHERE flightID = @FlightID AND userID = @UserID";
            var parameters = new Dictionary<string, object>
            {
                { "@FlightID", flightId },
                { "@UserID", userId }
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

        public override string ToString()
        {
            return $"Ticket Details:\n" +
                   $"ID: {Id}\n" +
                   $"Flight ID: {FlightID}\n" +
                   $"User ID: {UserID}\n" +
                   $"Seat: {Seat}\n" +
                   $"Ticket Class ID: {TicketClassID}\n" +
                   $"Ticket Status ID: {TicketStatusID}\n" +
                   $"Payment ID: {PaymentID}\n" +
                   $"Agency ID: {(AgencyID.HasValue ? AgencyID.ToString() : "None")}";
        }

        public static List<Ticket> GetTicketsByAgencyId(long agencyID)
        {
            string query = @"
                SELECT Id, flightID, userID, seat, ticketClassID, ticketStatusID, paymentID, agencyID 
                FROM tickets 
                WHERE agencyID = @AgencyID";
            var parameters = new Dictionary<string, object>
            {
                { "@AgencyID", agencyID }
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
