// This class provide interface to interact with the stored cities in database.

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class City
    {
        // City Attributes
        public long Id { get; set; } // Primary Key
        public string Name { get; set; } // Nullable
        public long CountryId { get; set; } // Foreign Key

        // Fetch all cities
        public static List<City> GetAllCities()
        {
            string query = "SELECT Id, name, country_id FROM cities";
            return Database.Instance.Query(query, reader => new City
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                CountryId = reader.GetInt32(2)
            });
        }

        // Add a new city
        public static bool AddCity(City city)
        {
            string query = @"

    INSERT INTO cities ( name, country_id)
    VALUES (@Name, @CountryId)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", (object)city.Name ?? DBNull.Value },
                { "@CountryId", city.CountryId }
            };

            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Update an existing city
        public static bool UpdateCity(City city)
        {
            string query = @"
                UPDATE cities
                SET name = @Name,
                    country_id = @CountryId
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", city.Id },
                { "@Name", (object)city.Name ?? DBNull.Value },
                { "@CountryId", city.CountryId }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a city
        public static bool DeleteCity(long id)
        {
            string query = "DELETE FROM cities WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a city by ID
        public static City GetCityById(long id)
        {
            string query = "SELECT Id, name, country_id FROM cities WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new City
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                CountryId = reader.GetInt32(2)
            });
            return result.Count > 0 ? result[0] : null;
        }

        // Fetch all cities for a specific country
        public static List<City> GetCitiesByCountryId(long countryId)
        {
            string query = "SELECT Id, name, country_id FROM cities WHERE country_id = @CountryId";
            var parameters = new Dictionary<string, object>
            {
                { "@CountryId", countryId }
            };
            return Database.Instance.Query(query, parameters, reader => new City
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                CountryId = reader.GetInt32(2)
            });
        }
    }
}
