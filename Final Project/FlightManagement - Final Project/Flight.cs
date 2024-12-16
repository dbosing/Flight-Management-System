using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace FlightManagement___Final_Project
{
    public class Flight
    {
        public string FlightCode { get; set; }
        public string Airline { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public int SeatsAvailable { get; set; }

        public static List<Flight> GetFlights()
        {
            var flights = new List<Flight>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Flights";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flights.Add(new Flight
                        {
                            FlightCode = reader.GetString(0),
                            Airline = reader.GetString(1),
                            Destination = reader.GetString(2),
                            DepartureTime = reader.GetDateTime(3),
                            SeatsAvailable = reader.GetInt32(4)
                        });
                    }
                }
            }
            return flights;
        }
    }
}
