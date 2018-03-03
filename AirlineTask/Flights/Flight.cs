using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineTask.Passengers;

namespace AirlineTask.Flights
{
    public sealed class Flight
    {
        private List<Passenger> flightPassengers;
        public string City { get; }
        public string FlightNumber { get; }
        public  Tuple<DateTime, DateTime> ArrivalAndDeparture { get; }
        public Tuple<string, string> TerminalAndGates { get; }
        public FlightStatus FlightStatus { get; set; }

        




    }
}
