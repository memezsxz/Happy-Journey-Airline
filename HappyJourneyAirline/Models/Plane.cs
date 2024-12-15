using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class Plane
    {
        public int Id { get; set; }
        public string Model { get; set; } // NOT NULL
        public int Capacity { get; set; } // NOT NULL

        // Fetch all planes
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

        // Add a new plane
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

        // Update an existing plane
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

        // Delete a plane
        public static bool DeletePlane(long id)
        {
            string query = "DELETE FROM planes WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a plane by ID
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
