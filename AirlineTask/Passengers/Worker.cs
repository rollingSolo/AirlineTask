using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    public class Worker:Passenger
    {

        public Worker()
        {

        }
        
       
        public override void ShowTerminalCommands()
        {
            FlightManager terminal = new FlightManager();
            Console.WriteLine(@"What are you looking for?
                                0 - Printing all flights
                                1 - Printing all flight’s passengers by flight number
                                2 - Searching passengers by Name or Last Name
                                3 - Searching passengers by Passport");

            string text = Console.ReadLine();

            switch (text)
            {
                case "0":
                    terminal.PrintAllFlightsInfo();
                    break;
                case "1":
                    terminal.SearchPassengersByFlightNumber();
                    break;

                case "2":
                    terminal.SearchPassengersByName();
                    break;

                case "3":
                    terminal.SearchPassengersByPassport();
                    break;

                default:
                    break;
            }
        }


        
    }
}
