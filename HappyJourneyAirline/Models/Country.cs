using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class Country
    {
        public long Id { get; set; } // Primary Key
        public string Name { get; set; } // Nullable

        // Fetch all countries
        public static List<Country> GetAllCountries()
        {
            string query = "SELECT Id, name FROM countries";
            return Database.Instance.Query(query, reader => new Country
            {
                Id = reader.GetInt64(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null
            });
        }

        // Add a new country
        public static bool AddCountry(Country country)
        {
            string query = @"
    INSERT INTO countries (name)
    VALUES (@Name)";
            var parameters = new Dictionary<string, object>
            {
                //{ "@Id", country.Id },
                { "@Name", (object)country.Name ?? DBNull.Value }
            };

            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Update an existing country
        public static bool UpdateCountry(Country country)
        {
            string query = @"
                UPDATE countries
                SET name = @Name
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", country.Id },
                { "@Name", (object)country.Name ?? DBNull.Value }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a country
        public static bool DeleteCountry(long id)
        {
            string query = "DELETE FROM countries WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a country by ID
        public static Country GetCountryById(long id)
        {
            string query = "SELECT Id, name FROM countries WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new Country
            {
                Id = reader.GetInt64(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
