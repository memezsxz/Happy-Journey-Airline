using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The Plane class provides an interface to interact with the stored planes in the database.
    /// It includes methods for retrieving, adding, updating, and deleting planes.
    /// </summary>
    public class Plane
    {
        /// <summary>
        /// Gets or sets the unique ID of the plane (Primary Key).
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the model of the plane (Required).
        /// </summary>
        public string Model { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the capacity of the plane (Required).
        /// </summary>
        public int Capacity { get; set; } // NOT NULL

        /// <summary>
        /// Retrieves all planes from the database.
        /// </summary>
        /// <returns>A list of all planes.</returns>
        public static List<Plane> GetAllPlanes()
        {
            string query = "SELECT Id, model, capacity FROM planes";
            return Database.Instance.Query(query, reader => new Plane
            {
                Id = reader.GetInt32(0),
                Model = reader.GetString(1).Trim(),
                Capacity = reader.GetInt32(2)
            });
        }

        /// <summary>
        /// Adds a new plane to the database.
        /// </summary>
        /// <param name="plane">The plane object containing plane details.</param>
        /// <returns>The ID of the newly added plane, or -1 if the operation failed.</returns>
        public static long AddPlane(Plane plane)
        {
            string query = @"
    INSERT INTO planes (model, capacity)
    OUTPUT INSERTED.Id
    VALUES (@Model, @Capacity)";
            var parameters = new Dictionary<string, object>
            {
                { "@Model", plane.Model },
                { "@Capacity", plane.Capacity }
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
        /// Updates an existing plane in the database.
        /// </summary>
        /// <param name="plane">The plane object containing updated plane details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
        public static bool UpdatePlane(Plane plane)
        {
            string query = @"
                UPDATE planes
                SET model = @Model,
                    capacity = @Capacity
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", plane.Id },
                { "@Model", plane.Model },
                { "@Capacity", plane.Capacity }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Deletes a plane from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the plane to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeletePlane(long id)
        {
            string query = "DELETE FROM planes WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a plane from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the plane to retrieve.</param>
        /// <returns>The plane object if found; otherwise, <c>null</c>.</returns>
        public static Plane GetPlaneById(long id)
        {
            string query = "SELECT Id, model, capacity FROM planes WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new Plane
            {
                Id = reader.GetInt32(0),
                Model = reader.GetString(1),
                Capacity = reader.GetInt32(2)
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
