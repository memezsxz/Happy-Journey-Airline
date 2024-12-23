using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// This class provides an interface to interact with the stored airports in the database.
    /// It includes methods for retrieving, adding, updating, and deleting airport records, as well as querying airports by city.
    /// </summary>
    public class Airport
    {
        /// <summary>
        /// Gets or sets the primary key of the airport.
        /// </summary>
        public int Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the name of the airport. This field is required.
        /// </summary>
        public string Name { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the ID of the city to which the airport belongs. This is a foreign key.
        /// </summary>
        public long CityId { get; set; } // Foreign Key

        /// <summary>
        /// Gets or sets the latitude of the airport. This field is required.
        /// </summary>
        public decimal Latitude { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the longitude of the airport. This field is required.
        /// </summary>
        public decimal Longitude { get; set; } // NOT NULL

        /// <summary>
        /// Retrieves all airports from the database.
        /// </summary>
        /// <returns>A list of <see cref="Airport"/> objects.</returns>
        public static List<Airport> GetAllAirports()
        {
            string query = "SELECT Id, name, cityId, latitude, longitude FROM airports";
            return Database.Instance.Query(query, reader => new Airport
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1).Trim(),
                CityId = reader.GetInt32(2),
                Latitude = reader.GetDecimal(3),
                Longitude = reader.GetDecimal(4)
            });
        }

        /// <summary>
        /// Adds a new airport to the database.
        /// </summary>
        /// <param name="airport">The <see cref="Airport"/> object to add.</param>
        /// <returns>The ID of the newly added airport, or -1 if the operation failed.</returns>
        public static int AddAirport(Airport airport)
        {
            string query = @"
    INSERT INTO airports (name, cityId, latitude, longitude)
    OUTPUT INSERTED.Id
    VALUES (@Name, @CityId, @Latitude, @Longitude)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", airport.Name },
                { "@CityId", airport.CityId },
                { "@Latitude", airport.Latitude },
                { "@Longitude", airport.Longitude }
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
        /// Updates an existing airport in the database.
        /// </summary>
        /// <param name="airport">The <see cref="Airport"/> object to update.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
        public static bool UpdateAirport(Airport airport)
        {
            string query = @"
                UPDATE airports
                SET name = @Name,
                    cityId = @CityId,
                    latitude = @Latitude,
                    longitude = @Longitude
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", airport.Id },
                { "@Name", airport.Name },
                { "@CityId", airport.CityId },
                { "@Latitude", airport.Latitude },
                { "@Longitude", airport.Longitude }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Deletes an airport from the database by ID. Also deletes associated flights.
        /// </summary>
        /// <param name="id">The ID of the airport to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeleteAirport(int id)
        {
            string query = "DELETE FROM airports WHERE Id = @Id";
            string query2 = "DELETE FROM flights WHERE destinationAirportID = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            Database.Instance.ExecuteNonQuery(query2, parameters);
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves an airport from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the airport to retrieve.</param>
        /// <returns>A <see cref="Airport"/> object if found; otherwise, <c>null</c>.</returns>
        public static Airport GetAirportById(int id)
        {
            string query = "SELECT Id, name, cityId, latitude, longitude FROM airports WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new Airport
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1).Trim(),
                CityId = reader.GetInt32(2),
                Latitude = reader.GetDecimal(3),
                Longitude = reader.GetDecimal(4)
            });
            return result.Count > 0 ? result[0] : null;
        }

        /// <summary>
        /// Retrieves all airports in a specific city.
        /// </summary>
        /// <param name="cityId">The ID of the city.</param>
        /// <returns>A list of <see cref="Airport"/> objects in the specified city.</returns>
        public static List<Airport> GetAirportsByCityId(long cityId)
        {
            string query = "SELECT Id, name, cityId, latitude, longitude FROM airports WHERE cityId = @CityId";
            var parameters = new Dictionary<string, object>
            {
                { "@CityId", cityId }
            };
            return Database.Instance.Query(query, parameters, reader => new Airport
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1).Trim(),
                CityId = reader.GetInt32(2),
                Latitude = reader.GetDecimal(3),
                Longitude = reader.GetDecimal(4)
            });
        }
    }
}
