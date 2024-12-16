using Microsoft.Data.SqlClient;

namespace FlightManagement___Final_Project
{
    public class DatabaseHelper
    {
        private const string ConnectionString = "Your Server";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}

