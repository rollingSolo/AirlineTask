using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    class Worker:Passenger
    {
        public override AccessLevels AccessLevel
        {
            get
            {
                return AccessLevels.Worker;
            }
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
