using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    public class Worker:Passenger
    {
        public override AccessLevels AccessLevel
        {
            get
            {
                return AccessLevels.Worker;
            }
        }

        public Worker()
        {

        }

        public Worker(string name,
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


        public void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public override void ShowTerminalCommands()
        {
            Terminal terminal = new Terminal();
            Console.WriteLine("What are you looking for ?");

            string text = Console.ReadLine();

            switch (text)
            {
                case "1":
                    terminal.PrintingFor();
                    break;
                default:
                    break;
            }
        }
    }
}
