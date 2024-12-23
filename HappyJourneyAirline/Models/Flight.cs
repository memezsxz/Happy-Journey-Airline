using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The Flight class provides an interface to interact with the stored flights in the database.
    /// It includes methods for retrieving, adding, updating, and deleting flights, as well as fetching travelers based on agency and flight.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Gets or sets the unique ID of the flight (Primary Key).
        /// </summary>
        public int Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the source airport ID associated with the flight (Foreign Key).
        /// </summary>
        public int SourceAirportID { get; set; } // Foreign Key

        /// <summary>
        /// Gets or sets the destination airport ID associated with the flight (Foreign Key).
        /// </summary>
        public int DestinationAirportID { get; set; } // Foreign Key

        /// <summary>
        /// Gets or sets the departure timestamp of the flight (Required).
        /// </summary>
        public DateTime DepartureTimestamp { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the arrival timestamp of the flight (Required).
        /// </summary>
        public DateTime ArrivalTimestamp { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the flight status ID (Nullable Foreign Key).
        /// </summary>
        public int? FlightStatusID { get; set; } // Nullable Foreign Key

        /// <summary>
        /// Gets or sets the plane ID associated with the flight (Foreign Key).
        /// </summary>
        public int PlaneID { get; set; } // Foreign Key

        /// <summary>
        /// Gets or sets the base price of the flight (Required).
        /// </summary>
        public decimal BasePrice { get; set; } // NOT NULL

        /// <summary>
        /// Returns a string representation of the Flight object.
        /// </summary>
        /// <returns>A string containing flight details.</returns>
        public override string ToString()
        {
            return $"Flight [Id={Id}, SourceAirportID={SourceAirportID}, DestinationAirportID={DestinationAirportID}, " +
                   $"DepartureTimestamp={DepartureTimestamp}, ArrivalTimestamp={ArrivalTimestamp}, " +
                   $"FlightStatusID={(FlightStatusID.HasValue ? FlightStatusID.ToString() : "None")}, PlaneID={PlaneID}, " +
                   $"BasePrice={BasePrice}]";
        }

        /// <summary>
        /// Retrieves all flights from the database.
        /// </summary>
        /// <returns>A list of all flights.</returns>
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

        /// <summary>
        /// Adds a new flight to the database.
        /// </summary>
        /// <param name="flight">The flight object containing flight details.</param>
        /// <returns>The ID of the newly added flight, or -1 if the operation failed.</returns>
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

        /// <summary>
        /// Updates an existing flight in the database.
        /// </summary>
        /// <param name="flight">The flight object containing updated flight details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Deletes a flight from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the flight to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeleteFlight(long id)
        {
            string query = "DELETE FROM flights WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a flight from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the flight to retrieve.</param>
        /// <returns>The flight object if found; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Retrieves all travelers for a specific agency by agency ID.
        /// </summary>
        /// <param name="agencyID">The ID of the agency.</param>
        /// <returns>A list of users associated with the agency.</returns>
        public static List<User> GetTravellersByAgencyID(long agencyID)
        {
            string query = @"
        SELECT DISTINCT u.Id, u.FirstName, u.LastName, u.Email, u.PhoneNumber
        FROM users u
        JOIN tickets t ON u.Id = t.UserID
        JOIN flights f ON t.FlightID = f.Id
        WHERE t.AgencyID = @AgencyID";

            var parameters = new Dictionary<string, object>
            {
                { "@AgencyID", agencyID }
            };

            return Database.Instance.Query(query, parameters, reader => new User
            {
                Id = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                Email = reader.GetString(3),
                PhoneNumber = reader.GetString(4)
            });
        }

        /// <summary>
        /// Retrieves travelers for a specific flight and agency by their IDs.
        /// </summary>
        /// <param name="agencyID">The ID of the agency.</param>
        /// <param name="flightID">The ID of the flight.</param>
        /// <returns>A list of users associated with the flight and agency.</returns>
        public static List<User> GetTravellersForFlightByAgencyID(long agencyID, long flightID)
        {
            string query = @"
        SELECT DISTINCT u.Id, u.FirstName, u.LastName, u.Email, u.PhoneNumber, u.cpr
FROM users u
JOIN tickets t ON u.Id = t.UserID
JOIN flights f ON t.FlightID = f.Id
WHERE t.FlightID = @FlightID
  AND t.AgencyID = @AgencyID;
";

            var parameters = new Dictionary<string, object>
            {
                { "@AgencyID", agencyID },
                { "@FlightID", flightID }
            };

            return Database.Instance.Query(query, parameters, reader => new User
            {
                Id = reader.GetInt64(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                Email = reader.GetString(3),
                PhoneNumber = reader.GetString(4),
                Cpr = reader.GetString(5)
            });
        }
    }
}
