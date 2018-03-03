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

        
        private readonly string city; 
        private readonly string flightNumber;
        private readonly Tuple<DateTime, DateTime> arrivalAndDeparture;
        private readonly Tuple<string, string> terminalAndGates;
        private readonly FlightStatus flightStatus = FlightStatus.Unknown;

        private List<Passenger> flightPassengers;
    }
}
