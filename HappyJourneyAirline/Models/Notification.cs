using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class Notification
    {
        public long Id { get; set; } // Primary Key
        public string Source { get; set; } // NOT NULL
        public string Type { get; set; } // NOT NULL
        public string Title { get; set; } // NOT NULL
        public string Description { get; set; } // NOT NULL
        public long UserId { get; set; } // Foreign Key (NOT NULL)

        // Fetch all notifications
        public static List<Notification> GetAllNotifications()
        {
            string query = "SELECT Id, source, type, title, description, user_id FROM notifications";
            return Database.Instance.Query(query, reader => new Notification
            {
                Id = reader.GetInt64(0),
                Source = reader.GetString(1),
                Type = reader.GetString(2),
                Title = reader.GetString(3),
                Description = reader.GetString(4),
                UserId = reader.GetInt64(5)
            });
        }

        // Add a new notification
        public static long AddNotification(Notification notification)
        {
            string query = @"
    INSERT INTO notifications (source, type, title, description, user_id)
    OUTPUT INSERTED.Id
    VALUES (@Source, @Type, @Title, @Description, @UserId)";
            var parameters = new Dictionary<string, object>
            {
                { "@Source", notification.Source },
                { "@Type", notification.Type },
                { "@Title", notification.Title },
                { "@Description", notification.Description },
                { "@UserId", notification.UserId }
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

        // Update an existing notification
        public static bool UpdateNotification(Notification notification)
        {
            string query = @"
                UPDATE notifications
                SET source = @Source,
                    type = @Type,
                    title = @Title,
                    description = @Description,
                    user_id = @UserId
                WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", notification.Id },
                { "@Source", notification.Source },
                { "@Type", notification.Type },
                { "@Title", notification.Title },
                { "@Description", notification.Description },
                { "@UserId", notification.UserId }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a notification
        public static bool DeleteNotification(long id)
        {
            string query = "DELETE FROM notifications WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a notification by ID
        public static Notification GetNotificationById(long id)
        {
            string query = "SELECT Id, source, type, title, description, user_id FROM notifications WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new Notification
            {
                Id = reader.GetInt64(0),
                Source = reader.GetString(1),
                Type = reader.GetString(2),
                Title = reader.GetString(3),
                Description = reader.GetString(4),
                UserId = reader.GetInt64(5)
            });
            return result.Count > 0 ? result[0] : null;
        }

        // Fetch all notifications for a specific user
        public static List<Notification> GetNotificationsByUserId(long userId)
        {
            string query = "SELECT Id, source, type, title, description, user_id FROM notifications WHERE user_id = @UserId";
            var parameters = new Dictionary<string, object>
            {
                { "@UserId", userId }
            };
            return Database.Instance.Query(query, parameters, reader => new Notification
            {
                Id = reader.GetInt64(0),
                Source = reader.GetString(1),
                Type = reader.GetString(2),
                Title = reader.GetString(3),
                Description = reader.GetString(4),
                UserId = reader.GetInt64(5)
            });
        }
    }
}
