using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FlightManagement___Final_Project
{
    public partial class Form1 : Form
    {
        private List<Flight> flights;

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
            PopulateDestinationFilter();
            LoadFilterOptions();
            InitializeListViewColumns();

            listViewFlights.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void InitializeListViewColumns()
        {
            listViewFlights.Columns.Clear(); 

            listViewFlights.Columns.Add("Flight Code", 120);
            listViewFlights.Columns.Add("Airline", 160);
            listViewFlights.Columns.Add("Destination", 150);
            listViewFlights.Columns.Add("Departure Time", 200);
            listViewFlights.Columns.Add("Seats Available", 150);


        }

        private void Form1_Load(string destination = null, DateTime? departureDate = null)
        {
            
            flights = Flight.GetFlights();

            // Filter flights based on the passed destination or departure date
            if (!string.IsNullOrEmpty(destination))
                flights = flights.Where(f => f.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase)).ToList();

            if (departureDate.HasValue)
                flights = flights.Where(f => f.DepartureTime.Date == departureDate.Value.Date).ToList();

            // Clears ListView and adds the updated list of flights
            listViewFlights.Items.Clear();
        }


        private void LoadFilterOptions()
        {
            // Gets the distinct flight destinations and airlines for filtering
            var destinations = flights.Select(f => f.Destination).Distinct().ToList();
            cmbFilterDestination.Items.Clear();
            cmbFilterDestination.Items.Add("All"); // Default option
            cmbFilterDestination.Items.AddRange(destinations.ToArray());
            cmbFilterDestination.SelectedIndex = 0;

            var airlines = flights.Select(f => f.Airline).Distinct().ToList();
            cmbFilterAirline.Items.Clear();
            cmbFilterAirline.Items.Add("All"); // Default option
            cmbFilterAirline.Items.AddRange(airlines.ToArray());
            cmbFilterAirline.SelectedIndex = 0;

            nudSeatsFilter.Value = 0;
        }

        private void FilterByDestination()
        {
            string selectedDestination = cmbFilterDestination.SelectedItem.ToString();
            flights = Flight.GetFlights();

            if (selectedDestination != "All")
                flights = flights.Where(f => f.Destination.Equals(selectedDestination, StringComparison.OrdinalIgnoreCase)).ToList();

            UpdateFlightListView();
        }

        private void FilterByAirline()
        {
            string selectedAirline = cmbFilterAirline.SelectedItem.ToString();
            flights = Flight.GetFlights();

            if (selectedAirline != "All")
                flights = flights.Where(f => f.Airline.Equals(selectedAirline, StringComparison.OrdinalIgnoreCase)).ToList();

            UpdateFlightListView();
        }

        private void FilterBySeats()
        {
            int minSeats = (int)nudSeatsFilter.Value;
            flights = Flight.GetFlights();

            if (minSeats > 0)
                flights = flights.Where(f => f.SeatsAvailable >= minSeats).ToList();

            UpdateFlightListView();
        }

        private void FilterByDate()
        {
            DateTime selectedDate = dtpFilterDate.Value.Date;
            flights = Flight.GetFlights();

            flights = flights.Where(f => f.DepartureTime.Date == selectedDate).ToList();

            UpdateFlightListView();
        }

        private void UpdateFlightListView()
        {
            listViewFlights.Items.Clear();

            foreach (var flight in flights)
            {
                var item = new ListViewItem(flight.FlightCode);
                item.SubItems.Add(flight.Airline);
                item.SubItems.Add(flight.Destination);
                item.SubItems.Add(flight.DepartureTime.ToString("g"));
                item.SubItems.Add(flight.SeatsAvailable.ToString());
                listViewFlights.Items.Add(item);
            }
        }

        private void cmbFilterDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByDestination();
        }

        private void cmbFilterAirline_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByAirline();
        }

        private void nudSeatsFilter_ValueChanged(object sender, EventArgs e)
        {
            FilterBySeats();
        }

        private void dtpFilterDate_ValueChanged(object sender, EventArgs e)
        {
            FilterByDate();
        }

        private void txtPassengerName_TextChanged(object sender, EventArgs e)
        {
            btnBook.Enabled = !string.IsNullOrWhiteSpace(txtPassengerName.Text) && listViewFlights.SelectedItems.Count > 0;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            // Reset filter controls
            cmbFilterDestination.SelectedIndex = 0;
            cmbFilterAirline.SelectedIndex = 0;
            dtpFilterDate.Value = DateTime.Now;
            nudSeatsFilter.Value = 0;
            Form1_Load();
        }

        private void PopulateDestinationFilter()
        {
            var flights = Flight.GetFlights();
            var destinations = new HashSet<string>(flights.Select(f => f.Destination));
            cmbFilterDestination.Items.Clear();
            cmbFilterDestination.Items.Add("All");
            cmbFilterDestination.Items.AddRange(destinations.ToArray());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1_Load();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (listViewFlights.SelectedItems.Count > 0)
            {
                var selectedItem = listViewFlights.SelectedItems[0];
                string flightCode = selectedItem.SubItems[0].Text;
                string passengerName = txtPassengerName.Text;

                if (!string.IsNullOrWhiteSpace(passengerName))
                {
                    Passenger.BookPassenger(passengerName, flightCode);
                    MessageBox.Show($"Booking confirmed for {passengerName} on Flight {flightCode}!");
                    Form1_Load();
                }
                else
                {
                    MessageBox.Show("Please enter a valid passenger name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a flight.");
            }
        }
    }
}
