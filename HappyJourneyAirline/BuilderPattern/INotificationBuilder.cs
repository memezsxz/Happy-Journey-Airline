using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyJourneyAirline.Models;

namespace HappyJourneyAirline.BuilderPattern
{
    public interface INotificationBuilder
    {
        Notification GetResult(); // Retrieve the built notification
        INotificationBuilder SetDescription(string description); // Set description
        INotificationBuilder SetSource(string source); // Set source
        INotificationBuilder SetTitle(string title); // Set title
        INotificationBuilder SetType(string type); // Set type
        INotificationBuilder SetUserId(long userId); // Set user ID
        void Reset(); // Reset the builder for reuse
    }
}
