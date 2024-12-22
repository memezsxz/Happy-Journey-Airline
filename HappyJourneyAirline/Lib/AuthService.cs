using System;
using System.IO;

namespace HappyJourneyAirline.Lib
{
    internal class AuthService
    {
        // Store the UserId in a text file
        public static void StoreUserId(long userId)
        {
            string filePath = "session.txt"; // file that contains the current session
            File.WriteAllText(filePath, userId.ToString());  // Store the user ID in a text file
        }

        // Check if the user is logged in by verifying if the user ID exists and is greater than 0
        public static bool IsUserLoggedIn()
        {
            string filePath = "session.txt"; // file that contain current session
            if (File.Exists(filePath)) // check if the session file exist
            {
                string storedUserId = File.ReadAllText(filePath); // read the session file content
                return int.TryParse(storedUserId, out int userId) && userId > 0; // if there is a valid session return true
            }
            return false;  // User is not logged in if no file exists or user ID is invalid
        }

        // Get the current logged-in user's ID
        public static long GetCurrentUserId()
        {
            string filePath = "session.txt"; // session file name
            if (File.Exists(filePath))
            {
                string storedUserId = File.ReadAllText(filePath); // read sesssion file
                if (long.TryParse(storedUserId, out long userId) && userId > 0) // check if there is correct logged in user
                {
                    return userId;  // Return the current logged-in user ID
                }
            }
            return -1;  // Return -1 if there is no logged-in user
        }

        // Remove the current logged-in user by deleting the user ID file
        public static void LogoutCurrentUser()
        {
            string filePath = "session.txt"; // the name of the session file
            if (File.Exists(filePath)) // check if the session file exists
            {
                File.Delete(filePath);  // Remove the user ID file to log out the user
            }
        }


    }
}