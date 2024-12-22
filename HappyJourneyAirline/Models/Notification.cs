using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The Notification class provides an interface to interact with the stored notifications in the database.
    /// It includes methods for retrieving, adding, updating, and deleting notifications, as well as filtering notifications by user.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Gets or sets the unique ID of the notification (Primary Key).
        /// </summary>
        public long Id { get; set; } // Primary Key

        /// <summary>
        /// Gets or sets the source of the notification (Required).
        /// </summary>
        public string Source { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the type of the notification (Required).
        /// </summary>
        public string Type { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the title of the notification (Required).
        /// </summary>
        public string Title { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the description of the notification (Required).
        /// </summary>
        public string Description { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the user ID associated with the notification (Foreign Key, Required).
        /// </summary>
        public long UserId { get; set; } // Foreign Key (NOT NULL)

        /// <summary>
        /// Retrieves all notifications from the database.
        /// </summary>
        /// <returns>A list of all notifications.</returns>
        public static List<Notification> GetAllNotifications()
        {
            string query = "SELECT Id, source, type, title, description, user_id FROM notifications";
            return Database.Instance.Query(query, reader => new Notification
            {
                Id = reader.GetInt32(0),
                Source = reader.GetString(1),
                Type = reader.GetString(2),
                Title = reader.GetString(3),
                Description = reader.GetString(4),
                UserId = reader.GetInt32(5)
            });
        }

        /// <summary>
        /// Adds a new notification to the database.
        /// </summary>
        /// <param name="notification">The notification object containing notification details.</param>
        /// <returns>The ID of the newly added notification, or -1 if the operation failed.</returns>
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

        /// <summary>
        /// Updates an existing notification in the database.
        /// </summary>
        /// <param name="notification">The notification object containing updated notification details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Deletes a notification from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the notification to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeleteNotification(long id)
        {
            string query = "DELETE FROM notifications WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a notification from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the notification to retrieve.</param>
        /// <returns>The notification object if found; otherwise, <c>null</c>.</returns>
        public static Notification GetNotificationById(long id)
        {
            string query = "SELECT Id, source, type, title, description, user_id FROM notifications WHERE Id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new Notification
            {
                Id = reader.GetInt32(0),
                Source = reader.GetString(1),
                Type = reader.GetString(2),
                Title = reader.GetString(3),
                Description = reader.GetString(4),
                UserId = reader.GetInt32(5)
            });
            return result.Count > 0 ? result[0] : null;
        }

        /// <summary>
        /// Retrieves all notifications for a specific user by their user ID.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>A list of notifications associated with the user.</returns>
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
