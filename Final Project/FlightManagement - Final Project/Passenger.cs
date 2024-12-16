using Microsoft.Data.SqlClient;

namespace FlightManagement___Final_Project
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string Name { get; set; }
        public string FlightCode { get; set; }

        public static void BookPassenger(string name, string flightCode)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                // Insert passenger
                string insertPassenger = "INSERT INTO Passengers (Name, FlightCode) VALUES (@Name, @FlightCode)";
                using (var command = new SqlCommand(insertPassenger, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@FlightCode", flightCode);
                    command.ExecuteNonQuery();
                }

                // Update seats available
                string updateSeats = "UPDATE Flights SET SeatsAvailable = SeatsAvailable - 1 WHERE FlightCode = @FlightCode";
                using (var command = new SqlCommand(updateSeats, connection))
                {
                    command.Parameters.AddWithValue("@FlightCode", flightCode);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
