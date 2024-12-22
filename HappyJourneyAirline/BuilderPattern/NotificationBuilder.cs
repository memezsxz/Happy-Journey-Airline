using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyJourneyAirline.Models;

namespace HappyJourneyAirline.BuilderPattern
{
    /// <summary>
    /// The NotificationBuilder class implements the INotificationBuilder interface to construct Notification objects.
    /// It uses the Builder Pattern to create and initialize Notification objects with specific attributes.
    /// </summary>
    public class NotificationBuilder : INotificationBuilder
    {
        /// <summary>
        /// Holds the current Notification object being built.
        /// </summary>
        private Notification result;

        /// <summary>
        /// Initializes a new instance of the NotificationBuilder class and resets its state.
        /// </summary>
        public NotificationBuilder()
        {
            Reset();
        }

        /// <summary>
        /// Resets the builder state by creating a new Notification object.
        /// </summary>
        public void Reset()
        {
            result = new Notification();
        }

        /// <summary>
        /// Retrieves the constructed Notification object, saves it to the database, and resets the builder for reuse.
        /// </summary>
        /// <returns>The newly created Notification object with an assigned ID.</returns>
        public Notification GetResult()
        {
            Notification builtNotification = result;
            long id = Notification.AddNotification(builtNotification); // Create the notification in the database
            builtNotification.Id = id; // Assign the created notification ID
            Reset(); // Reset for reuse
            return builtNotification; // Return the newly created notification
        }

        /// <summary>
        /// Sets the description of the notification.
        /// </summary>
        /// <param name="description">The description to set.</param>
        /// <returns>An instance of the builder for method chaining.</returns>
        public INotificationBuilder SetDescription(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                result.Description = description;
            }
            return this;
        }

        /// <summary>
        /// Sets the source of the notification.
        /// </summary>
        /// <param name="source">The source to set.</param>
        /// <returns>An instance of the builder for method chaining.</returns>
        public INotificationBuilder SetSource(string source)
        {
            if (!string.IsNullOrEmpty(source))
            {
                result.Source = source;
            }
            return this;
        }

        /// <summary>
        /// Sets the title of the notification.
        /// </summary>
        /// <param name="title">The title to set.</param>
        /// <returns>An instance of the builder for method chaining.</returns>
        public INotificationBuilder SetTitle(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                result.Title = title;
            }
            return this;
        }

        /// <summary>
        /// Sets the type of the notification.
        /// </summary>
        /// <param name="type">The type to set.</param>
        /// <returns>An instance of the builder for method chaining.</returns>
        public INotificationBuilder SetType(string type)
        {
            if (!string.IsNullOrEmpty(type))
            {
                result.Type = type;
            }
            return this;
        }

        /// <summary>
        /// Sets the user ID associated with the notification.
        /// </summary>
        /// <param name="userId">The user ID to set.</param>
        /// <returns>An instance of the builder for method chaining.</returns>
        public INotificationBuilder SetUserId(long userId)
        {
            if (userId > 0)
            {
                result.UserId = userId;
            }
            return this;
        }
    }
}
