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
                       "45693",
                       "9B",
                       "South",
                       7),
            new Flight("2008-05-01T07:34:42-5:00",
                       "2008-05-01T07:34:42-5:00",
                       "Panama",
                       "45693",
                       "9B",
                       "South",
                       7),
            new Flight("2008-05-01T07:34:42-5:00",
                       "2008-05-01T07:34:42-5:00",
                       "Odessa",
                       "45693",
                       "9B",
                       "North",
                       7),
            new Flight("2008-05-01T07:34:42-5:00",
                       "2008-05-01T07:34:42-5:00",
                       "Kiev",
                       "45693",
                       "9B",
                       "North",
                       7)

        };

        public void PrintFlightsInfo()
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

        public void ShowPassengersByFlightNumber()
        {
            
            foreach (var item in flights)
            {
                foreach (var secondItem in item.flightPassengers)
                {
                    secondItem.ShowInfo();
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
