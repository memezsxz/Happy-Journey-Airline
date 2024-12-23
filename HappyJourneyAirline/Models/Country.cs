using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The Country class provides an interface to interact with the stored countries in the database.
    /// It includes methods for retrieving, adding, updating, and deleting countries.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Gets or sets the unique ID of the country (Primary Key).
        /// </summary>
        public long Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the name of the country (Nullable).
        /// </summary>
        public string Name { get; set; } // Nullable

        /// <summary>
        /// Retrieves all countries from the database.
        /// </summary>
        /// <returns>A list of all countries.</returns>
        public static List<Country> GetAllCountries()
        {
            string query = "SELECT Id, name FROM countries";
            return Database.Instance.Query(query, reader => new Country
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null
            });
        }

        /// <summary>
        /// Adds a new country to the database.
        /// </summary>
        /// <param name="country">The country object containing country details.</param>
        /// <returns><c>true</c> if the addition was successful; otherwise, <c>false</c>.</returns>
        public static bool AddCountry(Country country)
        {
            string query = @"
    INSERT INTO countries (name)
    VALUES (@Name)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", (object)country.Name ?? DBNull.Value }
            };

            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Updates an existing country in the database.
        /// </summary>
        /// <param name="country">The country object containing updated country details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Deletes a country from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the country to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeleteCountry(long id)
        {
            string query = "DELETE FROM countries WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a country from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the country to retrieve.</param>
        /// <returns>The country object if found; otherwise, <c>null</c>.</returns>
        public static Country GetCountryById(long id)
        {
            string query = "SELECT Id, name FROM countries WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new Country
            {
                Id = reader.GetInt32(0),
                Name = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
