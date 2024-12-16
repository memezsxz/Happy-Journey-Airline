using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class Airport
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // NOT NULL
        public int CityId { get; set; } // Foreign Key
        public decimal Latitude { get; set; } // NOT NULL
        public decimal Longitude { get; set; } // NOT NULL

        // Fetch all airports
        public List<Airport> GetAllAirports()
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

        // Add a new airport
        public int AddAirport(Airport airport)
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

        // Update an existing airport
        public bool UpdateAirport(Airport airport)
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

        // Delete an airport
        public bool DeleteAirport(int id)
        {
            string query = "DELETE FROM airports WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find an airport by ID
        public Airport GetAirportById(int id)
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

        // Fetch all airports in a specific city
        public List<Airport> GetAirportsByCityId(int cityId)
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
