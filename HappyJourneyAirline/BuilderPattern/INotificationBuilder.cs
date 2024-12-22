using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyJourneyAirline.Models;

namespace HappyJourneyAirline.BuilderPattern
{
    /// <summary>
    /// The INotificationBuilder interface defines the contract for building Notification objects using the Builder Pattern.
    /// It provides methods to set individual attributes of a notification and to retrieve the built notification.
    /// </summary>
    public interface INotificationBuilder
    {
        /// <summary>
        /// Retrieves the constructed Notification object.
        /// </summary>
        /// <returns>The built Notification object.</returns>
        Notification GetResult(); // Retrieve the built notification

        /// <summary>
        /// Sets the description of the notification.
        /// </summary>
        /// <param name="description">The description to set.</param>
        /// <returns>An instance of the builder for method chaining.</returns>
        INotificationBuilder SetDescription(string description); // Set description

        /// <summary>
        /// Sets the source of the notification.
        /// </summary>
        /// <param name="source">The source to set.</param>
        /// <returns>An instance of the builder for method chaining.</returns>
        INotificationBuilder SetSource(string source); // Set source

        /// <summary>
        /// Sets the title of the notification.
        /// </summary>
        /// <param name="title">The title to set.</param>
        /// <returns>An instance of the builder for method chaining.</returns>
        INotificationBuilder SetTitle(string title); // Set title

        /// <summary>
        /// Sets the type of the notification.
        /// </summary>
        /// <param name="type">The type to set.</param>
        /// <returns>An instance of the builder for method chaining.</returns>
        INotificationBuilder SetType(string type); // Set type

        /// <summary>
        /// Sets the user ID associated with the notification.
        /// </summary>
        /// <param name="userId">The user ID to set.</param>
        /// <returns>An instance of the builder for method chaining.</returns>
        INotificationBuilder SetUserId(long userId); // Set user ID

        /// <summary>
        /// Resets the builder to its initial state, allowing it to be reused.
        /// </summary>
        void Reset(); // Reset the builder for reuse
    }
}
