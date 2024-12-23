using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// This class provides an interface to interact with the stored cities in the database.
    /// It includes methods for retrieving, adding, updating, and deleting city records, as well as querying cities by country.
    /// </summary>
    public class City
    {
        /// <summary>
        /// Gets or sets the primary key of the city.
        /// </summary>
        public long Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the name of the city. This is nullable.
        /// </summary>
        public string Name { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the ID of the country to which the city belongs. This is a foreign key.
        /// </summary>
        public long CountryId { get; set; } // Foreign Key

        /// <summary>
        /// Returns a string representation of the City object.
        /// </summary>
        /// <returns>A string containing city details.</returns>
        public override string ToString()
        {
            return $"City [Id={Id}, Name={Name}, CountryId={CountryId}]";
        }

        /// <summary>
        /// Retrieves all cities from the database.
        /// </summary>
        /// <returns>A list of <see cref="City"/> objects.</returns>
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

        /// <summary>
        /// Adds a new city to the database.
        /// </summary>
        /// <param name="city">The <see cref="City"/> object to add.</param>
        /// <returns><c>true</c> if the addition was successful; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Updates an existing city in the database.
        /// </summary>
        /// <param name="city">The <see cref="City"/> object to update.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Deletes a city from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the city to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeleteCity(long id)
        {
            string query = "DELETE FROM cities WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a city from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the city to retrieve.</param>
        /// <returns>A <see cref="City"/> object if found; otherwise, <c>null</c>.</returns>
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

        /// <summary>
        /// Retrieves all cities in a specific country.
        /// </summary>
        /// <param name="countryId">The ID of the country.</param>
        /// <returns>A list of <see cref="City"/> objects in the specified country.</returns>
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
