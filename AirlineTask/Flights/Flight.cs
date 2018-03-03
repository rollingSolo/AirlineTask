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
        public Tuple<DateTime, DateTime> ArrivalAndDeparture { get; }
        public string City { get; }
        public string FlightNumber { get; }
        public Tuple<string, string> TerminalAndGates { get; }
        public FlightStatus FlightStatus { get; }
        public List<Passenger> flightPassengers { get; set; }


        public Flight(string arrival,
                      string departure,
                      string city,
                      string flightNumber,
                      string terminal,
                      string gates,
                      int flightStatus)
        {
            this.ArrivalAndDeparture = new Tuple<DateTime, DateTime>
                                  ( DateTime.Parse(arrival), 
                                    DateTime.Parse(departure)
                                  );

            this.City = city;
            this.FlightNumber = flightNumber;
            this.TerminalAndGates = new Tuple<string, string>(terminal, gates);
            this.FlightStatus = (FlightStatus)flightStatus;
        }


        public void GetFlightInfo()
        {
            Console.WriteLine($"Flight № {this.FlightNumber} \r\n" +
                $"Arrival: {this.ArrivalAndDeparture.Item1} \r\n" +
                $"Departure: {this.ArrivalAndDeparture.Item2} \r\n" +
                $"Flight Number {this.FlightNumber} \r\n" +
                $"Terminal: {this.TerminalAndGates.Item1} \r\n" +
                $"Gates: {this.TerminalAndGates.Item2} \r\n" +
                $"Flight status: {this.FlightStatus} \r\n");
        }



    }
}
