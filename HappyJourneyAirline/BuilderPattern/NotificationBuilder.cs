using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyJourneyAirline.Models;

namespace HappyJourneyAirline.BuilderPattern
{
    public class NotificationBuilder : INotificationBuilder
    {
        private Notification result;

        // Constructor initializes a new Notification object
        public NotificationBuilder()
        {
            Reset();
        }

        // Reset the builder state
        public void Reset()
        {
            result = new Notification();
        }

        // Retrieve the built notification
        public Notification GetResult()
        {
            Notification builtNotification = result;
            long id = Notification.AddNotification(builtNotification); // create the notification in db
            builtNotification.Id = id; // assign the created notification with user
            Reset(); // Reset for reuse
            return builtNotification; // return the newly created user
        }

        // Set the description of the notification
        public INotificationBuilder SetDescription(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                result.Description = description;
            }
            return this;
        }

        // Set the source of the notification
        public INotificationBuilder SetSource(string source)
        {
            if (!string.IsNullOrEmpty(source))
            {
                result.Source = source;
            }
            return this;
        }

        // Set the title of the notification
        public INotificationBuilder SetTitle(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                result.Title = title;
            }
            return this;
        }

        // Set the type of the notification
        public INotificationBuilder SetType(string type)
        {
            if (!string.IsNullOrEmpty(type))
            {
                result.Type = type;
            }
            return this;
        }

        // Set the user ID of the notification
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
