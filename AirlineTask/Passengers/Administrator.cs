using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    public class Administrator : Passenger
    {
        public override AccessLevels AccessLevel
        {
            get
            {
                return AccessLevels.Administrator;
            }
        }

        public Administrator()
        {

        }
        public Administrator(string name,
                             string surName,
                             string nationality,
                             string passport,
                             string birthday,
                             int sex,
                             string airClass,
                             double ticketPrice) :

                            base(name,
                                surName,
                                nationality,
                                passport,
                                birthday,
                                sex,
                                airClass,
                                ticketPrice)
        {

        }
        public override void ShowTerminalCommands()
        {
            Terminal terminal = new Terminal();
            Console.WriteLine(@"What are you looking for?
                                0 - Printing all flights
                                1 - Printing all flight’s passengers by flight number
                                2 - Searching passengers by Name or Last Name
                                3 - Searching passengers by Passport
                                4 - Add Flight
                                5 - Add Passenger on Flight");

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

                case "4":
                    terminal.AddFlight();
                    break;
                case "5":
                    terminal.AddPassengerOnFlight();
                    break;

                default:
                    break;
            }

        }
    }
}
