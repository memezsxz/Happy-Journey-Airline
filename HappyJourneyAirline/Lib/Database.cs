using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyAirline.Lib
{
    public  class Database
    {
        private static readonly Lazy<Database> _instance = new Lazy<Database>(() => new Database());

        private Database() { }


        public static Database Instance => _instance.Value;

        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|\MyDatabase.mdf;";

        private SqlConnection _connection;

        private SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(connectionString);
            }

            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            return _connection;
        }


        public void CloseConnection()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public void ExecuteNonQuery(string query)
        {
            using (var command = new SqlCommand(query, GetConnection()))
            {
                command.ExecuteNonQuery();
            }
        }

        public SqlDataReader ExecuteReader(string query)
        {
            var command = new SqlCommand(query, GetConnection());
            return command.ExecuteReader();
        }
    }
}
