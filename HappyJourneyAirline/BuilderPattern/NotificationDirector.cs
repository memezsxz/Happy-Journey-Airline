using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyJourneyAirline.Models;

namespace HappyJourneyAirline.BuilderPattern
{
    /// <summary>
    /// Director class to manage the construction process of notifications.
    /// </summary>
    public class NotificationDirector
    {
        /// <summary>
        /// The builder instance used to construct notifications.
        /// </summary>
        private readonly INotificationBuilder builder;

        /// <summary>
        /// Initializes a new instance of the NotificationDirector class with the specified builder.
        /// </summary>
        /// <param name="builder">The builder instance used for constructing notifications.</param>
        public NotificationDirector(INotificationBuilder builder)
        {
            this.builder = builder;
        }

        /// <summary>
        /// Constructs an alert notification with the specified fields.
        /// </summary>
        /// <param name="source">The source of the notification.</param>
        /// <param name="title">The title of the notification.</param>
        /// <param name="description">The description of the notification.</param>
        /// <param name="userId">The user ID associated with the notification.</param>
        /// <returns>The constructed alert notification.</returns>
        public Notification ConstructAlertNotification(
            string source,
            string title,
            string description,
            long userId)
        {
            return builder
                .SetSource(source)
                .SetType("alert")
                .SetTitle(title)
                .SetDescription(description)
                .SetUserId(userId)
                .GetResult();
        }

        /// <summary>
        /// Constructs an important notification with the specified fields.
        /// </summary>
        /// <param name="source">The source of the notification.</param>
        /// <param name="title">The title of the notification.</param>
        /// <param name="description">The description of the notification.</param>
        /// <param name="userId">The user ID associated with the notification.</param>
        /// <returns>The constructed important notification.</returns>
        public Notification ConstructImportantNotification(
            string source,
            string title,
            string description,
            long userId)
        {
            return builder
                .SetSource(source)
                .SetType("important")
                .SetTitle(title)
                .SetDescription(description)
                .SetUserId(userId)
                .GetResult();
        }

        /// <summary>
        /// Constructs a marketing notification with the specified fields.
        /// </summary>
        /// <param name="source">The source of the notification.</param>
        /// <param name="title">The title of the notification.</param>
        /// <param name="description">The description of the notification.</param>
        /// <param name="userId">The user ID associated with the notification.</param>
        /// <returns>The constructed marketing notification.</returns>
        public Notification ConstructMarketingNotification(
            string source,
            string title,
            string description,
            long userId)
        {
            return builder
                .SetSource(source)
                .SetType("marketing")
                .SetTitle(title)
                .SetDescription(description)
                .SetUserId(userId)
                .GetResult();
        }
    }
}
