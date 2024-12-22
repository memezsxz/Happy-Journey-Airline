using System;
using System.IO;

namespace HappyJourneyAirline.Lib
{
    /// <summary>
    /// The AuthService class provides methods for managing user authentication and session handling.
    /// It uses a text file to store the current session's user ID.
    /// </summary>
    internal class AuthService
    {
        /// <summary>
        /// Stores the user ID in a session file to manage the current session.
        /// </summary>
        /// <param name="userId">The user ID to store in the session.</param>
        public static void StoreUserId(long userId)
        {
            string filePath = "session.txt"; // File that contains the current session
            File.WriteAllText(filePath, userId.ToString());  // Store the user ID in the file
        }

        /// <summary>
        /// Checks if a user is currently logged in by verifying the session file.
        /// </summary>
        /// <returns><c>true</c> if a valid user ID exists in the session file; otherwise, <c>false</c>.</returns>
        public static bool IsUserLoggedIn()
        {
            string filePath = "session.txt"; // File containing the current session
            if (File.Exists(filePath)) // Check if the session file exists
            {
                string storedUserId = File.ReadAllText(filePath); // Read the session file content
                return int.TryParse(storedUserId, out int userId) && userId > 0; // Return true if a valid session exists
            }
            return false;  // User is not logged in if no file exists or the user ID is invalid
        }

        /// <summary>
        /// Retrieves the user ID of the currently logged-in user from the session file.
        /// </summary>
        /// <returns>The user ID if a user is logged in; otherwise, -1.</returns>
        public static long GetCurrentUserId()
        {
            string filePath = "session.txt"; // Session file name
            if (File.Exists(filePath))
            {
                string storedUserId = File.ReadAllText(filePath); // Read the session file
                if (long.TryParse(storedUserId, out long userId) && userId > 0) // Verify the user ID is valid
                {
                    return userId;  // Return the current logged-in user ID
                }
            }
            return -1;  // Return -1 if no user is logged in
        }

        /// <summary>
        /// Logs out the current user by deleting the session file.
        /// </summary>
        public static void LogoutCurrentUser()
        {
            string filePath = "session.txt"; // Name of the session file
            if (File.Exists(filePath)) // Check if the session file exists
            {
                File.Delete(filePath);  // Delete the file to log out the user
            }
        }
    }
}
