using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    /// <summary>
    /// The User class provides an interface to interact with the user data in the database.
    /// It includes methods for retrieving, adding, updating, deleting users, and performing user-specific operations like login.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique ID of the user (Primary Key).
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the first name of the user (Nullable).
        /// </summary>
        public string FirstName { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the last name of the user (Nullable).
        /// </summary>
        public string LastName { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the phone number of the user (Required).
        /// </summary>
        public string PhoneNumber { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the username of the user (Required and Unique).
        /// </summary>
        public string Username { get; set; } // NOT NULL, Unique

        /// <summary>
        /// Gets or sets the email of the user (Required and Unique).
        /// </summary>
        public string Email { get; set; } // NOT NULL, Unique

        /// <summary>
        /// Gets or sets the password of the user (Required).
        /// </summary>
        public string Password { get; set; } // NOT NULL

        /// <summary>
        /// Gets or sets the type of the user. Default value is "traveller".
        /// </summary>
        public string Type { get; set; } = "traveller"; // Default Value

        /// <summary>
        /// Gets or sets the agency ID associated with the user (Nullable).
        /// </summary>
        public long? AgencyID { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the company name associated with the user (Nullable).
        /// </summary>
        public string CompanyName { get; set; } // Nullable

        /// <summary>
        /// Gets or sets the CPR (identification) of the user (Nullable).
        /// </summary>
        public string Cpr { get; set; } // Nullable


        /// <summary>
        /// Returns a string representation of the User object.
        /// </summary>
        /// <returns>A string containing user details.</returns>
        public override string ToString()
        {
            return $"User [Id={Id}, FirstName={FirstName}, LastName={LastName}, Username={Username}, Email={Email}, PhoneNumber={PhoneNumber}, Type={Type}, AgencyID={AgencyID}, CompanyName={CompanyName}, Cpr={Cpr}]";
        }

        /// <summary>
        /// Retrieves all users from the database.
        /// </summary>
        /// <returns>A list of all users.</returns>
        public static List<User> GetAllUsers()
        {
            string query = "SELECT id, firstName, lastName, username, email, password, type, agencyID, companyName, phoneNumber, cpr FROM users";
            return Database.Instance.Query(query, reader => new User
            {
                Id = reader.GetInt64(0),
                FirstName = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                LastName = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null,
                Username = !reader.IsDBNull(3) ? reader.GetString(3) : null,
                Email = !reader.IsDBNull(4) ? reader.GetString(4) : null,
                Password = !reader.IsDBNull(5) ? reader.GetString(5) : null,
                Type = !reader.IsDBNull(6) ? reader.GetString(6) : "traveller",
                AgencyID = !reader.IsDBNull(7) ? (int?)reader.GetInt64(7) : null,
                CompanyName = !reader.IsDBNull(8) ? reader.GetString(8) : null,
                PhoneNumber = !reader.IsDBNull(9) ? reader.GetString(9) : null,
                Cpr = !reader.IsDBNull(10) ? reader.GetString(10) : null
            });
        }

        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        /// <param name="user">The user object containing user details.</param>
        /// <returns>The ID of the newly added user, or -1 if the operation failed.</returns>
        public static long AddUser(User user)
        {
            string query = @"
    INSERT INTO users (firstName, lastName, username, email, password, type, agencyID, companyName, phoneNumber, cpr)
    OUTPUT INSERTED.id
    VALUES (@FirstName, @LastName, @Username, @Email, @Password, @Type, @AgencyID, @CompanyName, @PhoneNumber, @Cpr)";

            var parameters = new Dictionary<string, object>
            {
                { "@FirstName", (object)user.FirstName ?? DBNull.Value },
                { "@LastName", (object)user.LastName ?? DBNull.Value },
                { "@PhoneNumber", user.PhoneNumber },
                { "@Username", (object)user.Username ?? DBNull.Value },
                { "@Email", user.Email },
                { "@Password", (object)user.Password ?? DBNull.Value },
                { "@Type", (object)user.Type ?? "traveller" },
                { "@AgencyID", (object)user.AgencyID ?? DBNull.Value },
                { "@CompanyName", (object)user.CompanyName ?? DBNull.Value },
                { "@Cpr", (object)user.Cpr ?? DBNull.Value }
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

            return -1;
        }

        /// <summary>
        /// Updates an existing user in the database.
        /// </summary>
        /// <param name="user">The user object containing updated user details.</param>
        /// <returns><c>true</c> if the update was successful; otherwise, <c>false</c>.</returns>
        public static bool UpdateUser(User user)
        {
            string query = @"
                UPDATE users
                SET firstName = @FirstName,
                    lastName = @LastName,
                    phoneNumber = @PhoneNumber,
                    username = @Username,
                    email = @Email,
                    password = @Password,
                    type = @Type,
                    agencyID = @AgencyID,
                    companyName = @CompanyName,
                    cpr = @Cpr
                WHERE id = @Id";

            var parameters = new Dictionary<string, object>
            {
                { "@Id", user.Id },
                { "@FirstName", (object)user.FirstName ?? DBNull.Value },
                { "@LastName", (object)user.LastName ?? DBNull.Value },
                { "@PhoneNumber", user.PhoneNumber },
                { "@Username", user.Username },
                { "@Email", user.Email },
                { "@Password", user.Password },
                { "@Type", (object)user.Type ?? "traveller" },
                { "@AgencyID", (object)user.AgencyID ?? DBNull.Value },
                { "@CompanyName", (object)user.CompanyName ?? DBNull.Value },
                { "@Cpr", (object)user.Cpr ?? DBNull.Value }
            };

            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Deletes a user from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        /// <returns><c>true</c> if the deletion was successful; otherwise, <c>false</c>.</returns>
        public static bool DeleteUser(long id)
        {
            string query = "DELETE FROM users WHERE id = @Id";
            string query2 = "DELETE FROM tickets where userID = @Id or agencyID = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            Database.Instance.ExecuteNonQuery(query2, parameters);
            return Database.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        /// <summary>
        /// Retrieves a user from the database by their ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>The user object if found; otherwise, <c>null</c>.</returns>
        public static User GetUserById(long id)
        {
            string query = "SELECT id, firstName, lastName, username, email, password, type, agencyID, companyName, phoneNumber, cpr FROM users WHERE id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = Database.Instance.Query(query, parameters, reader => new User
            {
                Id = reader.GetInt64(0),
                FirstName = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                LastName = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null,
                Username = reader.GetString(3),
                Email = reader.GetString(4),
                Password = reader.GetString(5),
                Type = !reader.IsDBNull(6) ? reader.GetString(6) : "traveller",
                AgencyID = !reader.IsDBNull(7) ? (int?)reader.GetInt64(7) : null,
                CompanyName = !reader.IsDBNull(8) ? reader.GetString(8) : null,
                PhoneNumber = reader.GetString(9),
                Cpr = !reader.IsDBNull(10) ? reader.GetString(10) : null
            });
            return result.Count > 0 ? result[0] : null;
        }

        /// <summary>
        /// Authenticates a user based on their username and password.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>The authenticated user object if credentials are valid; otherwise, <c>null</c>.</returns>
        public User Login(string username, string password)
        {
            string query = "SELECT id, firstName, lastName, username, email, password, type, agencyID, companyName, phoneNumber, cpr FROM users WHERE username = @Username AND password = @Password";
            var parameters = new Dictionary<string, object>
            {
                { "@Username", username },
                { "@Password", password }
            };
            var result = Database.Instance.Query(query, parameters, reader => new User
            {
                Id = reader.GetInt64(0),
                FirstName = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                LastName = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : null,
                Username = reader.GetString(3),
                Email = reader.GetString(4),
                Password = reader.GetString(5),
                Type = !reader.IsDBNull(6) ? reader.GetString(6) : "traveller",
                AgencyID = !reader.IsDBNull(7) ? (int?)reader.GetInt64(7) : null,
                CompanyName = !reader.IsDBNull(8) ? reader.GetString(8) : null,
                PhoneNumber = reader.GetString(9),
                Cpr = !reader.IsDBNull(10) ? reader.GetString(10) : null
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
