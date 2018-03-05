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
        public List<Passenger> flightPassengers = new List<Passenger>()
        {
            new User("Vasiliy",
                     "Petrovich",
                     "Kumys",
                     "BT228337",
                     "2017-05-01T07:34:42-5:00",
                     0,
                     "Budget",
                     228),


            new User("Svetlana",
                     "Petrovna",
                     "Kumys",
                     "BT228449",
                     "2017-05-01T07:34:42-5:00",
                     1,
                     "Premium",
                     449),
            new User("Svetlana",
                     "Petrovna",
                     "Kumys",
                     "BT228449",
                     "2017-05-01T07:34:42-5:00",
                     1,
                     "Premium",
                     449)


        };


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
                                    DateTime.Parse(departure));

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
                $"Flight Number: {this.FlightNumber} \r\n" +
                $"Terminal: {this.TerminalAndGates.Item1} \r\n" +
                $"Gates: {this.TerminalAndGates.Item2} \r\n" +
                $"Flight status: {this.FlightStatus} \r\n");
        }


        public List<Passenger> AddPassenger()
        {
            Console.WriteLine("Enter your Firstname:");
            string passengerName = Console.ReadLine();

            Console.WriteLine("Enter your Lastname:");
            string passengerSurname = Console.ReadLine();

            Console.WriteLine("Enter your Nationality:");
            string nationality = Console.ReadLine();

            Console.WriteLine("Enter Passport Information (example MT2827512):");
            string passportInfo = Console.ReadLine();

            Console.WriteLine("Enter your Birthday (example 2017-05-01T07:34:42-5:00):");
            string birthday = Console.ReadLine();

            Console.WriteLine(@"Enter your sex from the two proposed:
                              0 - Male
                              1 - Female");

            int sex  = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Airplane Class:");
            string airPlaneClass = Console.ReadLine();

            Console.WriteLine("Enter the Ticket Price:");
            double ticketPrice  = double.Parse(Console.ReadLine());

            var passenger = new User(passengerName, 
                                     passengerSurname, 
                                     nationality, 
                                     passportInfo, 
                                     birthday, 
                                     sex,
                                     airPlaneClass,
                                     ticketPrice);
            flightPassengers.Add(passenger);


            return flightPassengers;
        }


        public void ShowPassengers()
        {
            foreach (var item in flightPassengers)
            {
                item.ShowInfo();
                
            }
        }

        


        


    }
}
