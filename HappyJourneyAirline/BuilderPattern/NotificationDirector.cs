using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyJourneyAirline.Models;

namespace HappyJourneyAirline.BuilderPattern
{
    // Director class to manage the construction process
    public class NotificationDirector
    {
        private readonly INotificationBuilder builder;

        // Constructor accepts a builder instance
        public NotificationDirector(INotificationBuilder builder)
        {
            this.builder = builder;
        }

        // Construct a alert notification with all fields
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

        // Construct a important notification with all fields
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

        // Construct a marketing notification with all fields
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
