using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class Flight
    {
        public long Id { get; set; } // Primary Key
        public int SourceAirportID { get; set; } // Foreign Key
        public int DestinationAirportID { get; set; } // Foreign Key
        public DateTime DepartureTimestamp { get; set; } // NOT NULL
        public DateTime ArrivalTimestamp { get; set; } // NOT NULL
        public int? FlightStatusID { get; set; } // Nullable Foreign Key
        public int PlaneID { get; set; } // Foreign Key
        public decimal BasePrice { get; set; } // NOT NULL

        // Fetch all flights
        public List<Flight> GetAllFlights()
        {
            string query = @"
                SELECT Id, sourceAirportID, destinationAirportID, departureTimestamp, arrivalTimestamp, 
                       flightStatusID, planeID, basePrice 
                FROM flights";
            return Database.Instance.Query(query, reader => new Flight
            {
                Id = reader.GetInt64(0),
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
        public long AddFlight(Flight flight)
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
        public bool UpdateFlight(Flight flight)
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
        public bool DeleteFlight(long id)
        {
            string query = "DELETE FROM flights WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a flight by ID
        public Flight GetFlightById(long id)
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
                Id = reader.GetInt64(0),
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
    }
}
