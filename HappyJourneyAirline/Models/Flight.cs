using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class Flight
    {
        public int Id { get; set; } // Primary Key
        public int SourceAirportID { get; set; } // Foreign Key
        public int DestinationAirportID { get; set; } // Foreign Key
        public DateTime DepartureTimestamp { get; set; } // NOT NULL
        public DateTime ArrivalTimestamp { get; set; } // NOT NULL
        public int? FlightStatusID { get; set; } // Nullable Foreign Key
        public int PlaneID { get; set; } // Foreign Key
        public decimal BasePrice { get; set; } // NOT NULL

        // Fetch all flights
        public static List<Flight> GetAllFlights()
        {
            string query = @"
                SELECT Id, sourceAirportID, destinationAirportID, departureTimestamp, arrivalTimestamp, 
                       flightStatusID, planeID, BasePrice 
                FROM flights";
            return Database.Instance.Query(query, reader => new Flight
            {
                Id = reader.GetInt32(0),
                SourceAirportID = reader.GetInt32(1),
                DestinationAirportID = reader.GetInt32(2),
                DepartureTimestamp = reader.GetDateTime(3),
                ArrivalTimestamp = reader.GetDateTime(4),
                FlightStatusID = !reader.IsDBNull(5) ? reader.GetInt32(5) : (int?)null,
                PlaneID = reader.GetInt32(6),
                BasePrice = reader.GetDecimal(7)
            });
        }

        // Add a new flight
        public static long AddFlight(Flight flight)
        {
            string query = @"
    INSERT INTO flights (sourceAirportID, destinationAirportID, departureTimestamp, arrivalTimestamp, flightStatusID, planeID, basePrice)
    OUTPUT INSERTED.Id
    VALUES (@SourceAirportID, @DestinationAirportID, @DepartureTimestamp, @ArrivalTimestamp, @FlightStatusID, @PlaneID, @BasePrice)";
            var parameters = new Dictionary<string, object>
            {
                { "@SourceAirportID", flight.SourceAirportID },
                { "@DestinationAirportID", flight.DestinationAirportID },
                { "@DepartureTimestamp", flight.DepartureTimestamp },
                { "@ArrivalTimestamp", flight.ArrivalTimestamp },
                { "@FlightStatusID", (object)flight.FlightStatusID ?? DBNull.Value },
                { "@PlaneID", flight.PlaneID },
                { "@BasePrice", flight.BasePrice }
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

        // Update an existing flight
        public static bool UpdateFlight(Flight flight)
        {
            string query = @"
                UPDATE flights
                SET sourceAirportID = @SourceAirportID,
                    destinationAirportID = @DestinationAirportID,
                    departureTimestamp = @DepartureTimestamp,
                    arrivalTimestamp = @ArrivalTimestamp,
                    flightStatusID = @FlightStatusID,
                    planeID = @PlaneID,
                    basePrice = @BasePrice
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", flight.Id },
                { "@SourceAirportID", flight.SourceAirportID },
                { "@DestinationAirportID", flight.DestinationAirportID },
                { "@DepartureTimestamp", flight.DepartureTimestamp },
                { "@ArrivalTimestamp", flight.ArrivalTimestamp },
                { "@FlightStatusID", (object)flight.FlightStatusID ?? DBNull.Value },
                { "@PlaneID", flight.PlaneID },
                { "@BasePrice", flight.BasePrice }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a flight
        public static bool DeleteFlight(long id)
        {
            string query = "DELETE FROM flights WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a flight by ID
        public static Flight GetFlightById(long id)
        {
            string query = @"
                SELECT Id, sourceAirportID, destinationAirportID, departureTimestamp, arrivalTimestamp, 
                       flightStatusID, planeID, basePrice 
                FROM flights 
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new Flight
            {
                Id = reader.GetInt32(0),
                SourceAirportID = reader.GetInt32(1),
                DestinationAirportID = reader.GetInt32(2),
                DepartureTimestamp = reader.GetDateTime(3),
                ArrivalTimestamp = reader.GetDateTime(4),
                FlightStatusID = !reader.IsDBNull(5) ? reader.GetInt32(5) : (int?)null,
                PlaneID = reader.GetInt32(6),
                BasePrice = reader.GetDecimal(7)
            });
            return result.Count > 0 ? result[0] : null;
        }


        public override string ToString()
        {
            return $"Flight Information:\n" +
                   $"Plane ID: {PlaneID}\n" +
                   $"Departure: {DepartureTimestamp}\n" +
                   $"Arrival: {ArrivalTimestamp}\n" +
                   $"Base Price: {BasePrice:C}\n" + // Format as currency
                   $"Source Airport ID: {SourceAirportID}\n" +
                   $"Destination Airport ID: {DestinationAirportID}\n" +
                   $"Flight Status ID: {FlightStatusID}";
        }


        public static List<User> GetTravellersByAgencyID(long agencyID)
        {
            string query = @"
        SELECT DISTINCT u.Id, u.FirstName, u.LastName, u.Email, u.PhoneNumber
        FROM users u
        JOIN tickets t ON u.Id = t.UserID
        JOIN flights f ON t.FlightID = f.Id
        WHERE f.AgencyID = @AgencyID";

            var parameters = new Dictionary<string, object>
    {
        { "@AgencyID", agencyID }
    };

            return Database.Instance.Query(query, parameters, reader => new User
            {
                Id = reader.GetInt64(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                Email = reader.GetString(3),
                PhoneNumber = reader.GetString(4)
            });
        }

    }


}
