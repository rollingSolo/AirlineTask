using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineTask.Flights;
using AirlineTask.Passengers;

namespace AirlineTask
{
    public sealed class Terminal
    {

        private List<Flight> flights = new List<Flight>()
        {
            new Flight("2017-05-01T07:34:42-5:00",
                       "2017-05-02T07:34:42-5:00",
                       "NewYork",
                       "102",
                       "9B",
                       "South",
                       7),
            new Flight("2008-05-01T07:34:42-5:00",
                       "2008-05-01T07:34:42-5:00",
                       "Panama",
                       "103",
                       "9B",
                       "South",
                       7),
            new Flight("2008-05-01T07:34:42-5:00",
                       "2008-05-01T07:34:42-5:00",
                       "Odessa",
                       "104",
                       "9B",
                       "North",
                       7),
            new Flight("2008-05-01T07:34:42-5:00",
                       "2008-05-01T07:34:42-5:00",
                       "Kiev",
                       "105",
                       "9B",
                       "North",
                       7)

        };

        public void PrintAllFlightsInfo()
        {
            foreach (var item in flights)
            {
                item.GetFlightInfo();
            }
        }



        public void PrintingFor()
        {
            Console.WriteLine("idi nahuy");
        }

        public void SearchPassengersByFlightNumber()
        {
            Console.WriteLine("Enter the flight number (example : 102)");
            string inputFlightNumber = Console.ReadLine();


            foreach (var flight in flights)
            {
                foreach (var passenger in flight.flightPassengers)
                {
                    if (flight.FlightNumber.Equals(inputFlightNumber))
                    {
                        passenger.ShowInfo();
                    }
                }
            }
        }

        public void SearchPassengersByName()
        {
            Console.WriteLine("Enter the passenger Name or Lastname");
            string inputNameOrLastName = Console.ReadLine();


            foreach (var flight in flights)
            {
                foreach (var passenger in flight.flightPassengers)
                {
                    if (passenger.Name.ToLower().Contains(inputNameOrLastName) ||
                        passenger.Surname.ToLower().Contains(inputNameOrLastName))
                    {
                        Console.WriteLine(flight.FlightNumber);
                        passenger.ShowInfo();
                    }
                }
            }
        }

        public void SearchPassengersByPassport()
        {
            Console.WriteLine("Enter the passenger's passport");
            string passport = Console.ReadLine();


            foreach (var flight in flights)
            {
                foreach (var passenger in flight.flightPassengers)
                {
                    if (passenger.Passport.Equals(passport))
                    {
                        Console.WriteLine(flight.FlightNumber);
                        passenger.ShowInfo();
                    }
                }
            }
        }

        public List<Flight> AddFlight()
        {   

            Console.WriteLine("Enter the flight number:");
            string flightNumber = Console.ReadLine();

            Console.WriteLine("Enter the City");
            string city = Console.ReadLine();

            Console.WriteLine("Enter the date of arrival (example 2017-05-01T07:34:42-5:00):");
            string arrival = Console.ReadLine();

            Console.WriteLine("Enter the date of departure (example 2017-05-01T07:34:42-5:00):");
            string departure = Console.ReadLine();

            Console.WriteLine("Enter the terminal");
            string terminal = Console.ReadLine();

            Console.WriteLine("Enter the gates");
            string gates = Console.ReadLine();


            Console.WriteLine(@"Enter the flight status: 
                               0 - CheckIn
                               1 - GateClosed
                               2 - Arrived
                               3 - Departure
                               4 - Unknown
                               5 - Canceled
                               6 - Expected
                               7 - Delay
                               8 - InFlight ");

            int flightStatus = int.Parse(Console.ReadLine());


            var flight = new Flight(arrival,
                                    departure,
                                    city,
                                    flightNumber,
                                    terminal,
                                    gates,
                                    flightStatus);
            flights.Add(flight);

            return flights;
        }

    }


    
}
