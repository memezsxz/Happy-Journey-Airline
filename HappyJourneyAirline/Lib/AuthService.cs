using System;
using System.IO;

namespace HappyJourneyAirline.Lib
{
    internal class AuthService
    {
        // Store the UserId in a text file
        public static void StoreUserId(long userId)
        {
            string filePath = "session.txt";
            File.WriteAllText(filePath, userId.ToString());  // Store the user ID in a text file
        }

        // Check if the user is logged in by verifying if the user ID exists and is greater than 0
        public static bool IsUserLoggedIn()
        {
            string filePath = "session.txt";
            if (File.Exists(filePath))
            {
                string storedUserId = File.ReadAllText(filePath);
                return int.TryParse(storedUserId, out int userId) && userId > 0;
            }
            return false;  // User is not logged in if no file exists or user ID is invalid
        }

        // Get the current logged-in user's ID
        public static long GetCurrentUserId()
        {
            string filePath = "session.txt";
            if (File.Exists(filePath))
            {
                string storedUserId = File.ReadAllText(filePath);
                if (long.TryParse(storedUserId, out long userId) && userId > 0)
                {
                    return userId;  // Return the current logged-in user ID
                }
            }
            return -1;  // Return -1 if there is no logged-in user
        }

        // Remove the current logged-in user by deleting the user ID file
        public static void LogoutCurrentUser()
        {
            string filePath = "session.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);  // Remove the user ID file to log out the user
            }
        }


    }
}