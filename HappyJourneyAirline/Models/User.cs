// User Class, the purpose of it to interact with the user data in the database.

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class User
    {
        // User Attributes
        public long Id { get; set; }
        public string FirstName { get; set; } // Nullable
        public string LastName { get; set; } // Nullable
        public string PhoneNumber { get; set; } // NOT NULL
        public string Username { get; set; } // NOT NULL, Unique
        public string Email { get; set; } // NOT NULL, Unique
        public string Password { get; set; } // NOT NULL
        public string Type { get; set; } = "traveller"; // Default Value
        public long? AgencyID { get; set; } // Nullable
        public string CompanyName { get; set; } // Nullable
        public string Cpr { get; set; } // Nullable

        // Fetch all users
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

        // Add a new user
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
                { "@Username", user.Username },
                { "@Email", user.Email },
                { "@Password", user.Password },
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

        // Update an existing user
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

        // Delete a user
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

        // Find a user by ID
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
                AgencyID = !reader.IsDBNull(7) ? (int?)reader.GetInt32(7) : null,
                CompanyName = !reader.IsDBNull(8) ? reader.GetString(8) : null,
                PhoneNumber = reader.GetString(9),
                Cpr = !reader.IsDBNull(10) ? reader.GetString(10) : null
            });
            return result.Count > 0 ? result[0] : null;
        }

        // Login method
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
                AgencyID = !reader.IsDBNull(7) ? (int?)reader.GetInt32(7) : null,
                CompanyName = !reader.IsDBNull(8) ? reader.GetString(8) : null,
                PhoneNumber = reader.GetString(9),
                Cpr = !reader.IsDBNull(10) ? reader.GetString(10) : null
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
