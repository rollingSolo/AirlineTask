using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    class User : Passenger
    {
        public override AccessLevels AccessLevel
        {
            get
            {
                return AccessLevels.User;
            }
        }

        public override void ShowTerminalCommands()
        {
            Terminal terminal = new Terminal();
            Console.WriteLine("What are you looking for ?");

            string text = Console.ReadLine();

            switch (text)
            {
                case "1":
                    terminal.PrintFlightsInfo();
                    break;
                default:
                    break;
            }

        }
    }
}
