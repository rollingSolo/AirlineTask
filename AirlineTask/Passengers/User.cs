using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    public class User : Passenger
    {
        public override AccessLevels AccessLevel
        {
            get
            {
                return AccessLevels.User;
            }
        }

        public User()
        {

        }
        public User(string name,
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
            Console.WriteLine("Hi please press enter to see all flights");

            Console.ReadLine();

            terminal.PrintAllFlightsInfo();

        }

        
    }
}
