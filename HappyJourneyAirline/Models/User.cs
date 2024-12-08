using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyJourneyAirline.Lib;

namespace HappyJourneyAirline.Models
{
    public class User
    {
        public long Id { get; set; }
        public string FullName { get; set; } // Nullable fields handled explicitly
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; } // Nullable fields handled explicitly
        public long? AgencyID { get; set; }
        public string CompanyName { get; set; } // Nullable fields handled explicitly

        private readonly Database _database;

        public User()
        {
            _database = new Database();
        }

        // Fetch all users
        public List<User> GetAllUsers()
        {
            string query = "SELECT id, fullName, username, email, password, type, agencyID, companyName FROM users";
            return _database.Query(query, reader => new User
            {
                Id = reader.GetInt64(0),
                FullName = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Username = reader.GetString(2),
                Email = reader.GetString(3),
                Password = reader.GetString(4),
                Type = !reader.IsDBNull(5) ? reader.GetString(5) : null,
                AgencyID = !reader.IsDBNull(6) ? (long?)reader.GetInt64(6) : null,
                CompanyName = !reader.IsDBNull(7) ? reader.GetString(7) : null
            });
        }

        // Add a new user
        public bool AddUser(User user)
        {
            string query = @"
                INSERT INTO users (id, fullName, username, email, password, type, agencyID, companyName)
                VALUES (@Id, @FullName, @Username, @Email, @Password, @Type, @AgencyID, @CompanyName)";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", user.Id },
                { "@FullName", (object)user.FullName ?? DBNull.Value },
                { "@Username", user.Username },
                { "@Email", user.Email },
                { "@Password", user.Password },
                { "@Type", (object)user.Type ?? DBNull.Value },
                { "@AgencyID", (object)user.AgencyID ?? DBNull.Value },
                { "@CompanyName", (object)user.CompanyName ?? DBNull.Value }
            };
            return _database.ExecuteNonQuery(query, parameters) > 0;
        }

        // Update an existing user
        public bool UpdateUser(User user)
        {
            string query = @"
                UPDATE users
                SET fullName = @FullName,
                    username = @Username,
                    email = @Email,
                    password = @Password,
                    type = @Type,
                    agencyID = @AgencyID,
                    companyName = @CompanyName
                WHERE id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", user.Id },
                { "@FullName", (object)user.FullName ?? DBNull.Value },
                { "@Username", user.Username },
                { "@Email", user.Email },
                { "@Password", user.Password },
                { "@Type", (object)user.Type ?? DBNull.Value },
                { "@AgencyID", (object)user.AgencyID ?? DBNull.Value },
                { "@CompanyName", (object)user.CompanyName ?? DBNull.Value }
            };
            return _database.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a user
        public bool DeleteUser(long id)
        {
            string query = "DELETE FROM users WHERE id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            return _database.ExecuteNonQuery(query, parameters) > 0;
        }

        // Find a user by ID
        public User GetUserById(long id)
        {
            string query = "SELECT id, fullName, username, email, password, type, agencyID, companyName FROM users WHERE id = @Id";
            var parameters = new Dictionary<string, object>
            {
                { "@Id", id }
            };
            var result = _database.Query(query, reader => new User
            {
                Id = reader.GetInt64(0),
                FullName = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : null,
                Username = reader.GetString(2),
                Email = reader.GetString(3),
                Password = reader.GetString(4),
                Type = !reader.IsDBNull(5) ? reader.GetString(5) : null,
                AgencyID = !reader.IsDBNull(6) ? (long?)reader.GetInt64(6) : null,
                CompanyName = !reader.IsDBNull(7) ? reader.GetString(7) : null
            });
            return result.Count > 0 ? result[0] : null;
        }
    }
}
