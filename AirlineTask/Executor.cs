using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AirlineTask.Flights;
using AirlineTask.Passengers;

namespace AirlineTask
{
    class Executor
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hi, Olga!! Welcome to AirLine Terminal, today {DateTime.Now} \r\n" +
                              $"Press Enter to continue");
            

            Console.ReadLine();

            Console.WriteLine(@"Enter your role:
                               1 - Administrator
                               2 - Worker
                               3 - User");

            

            string identitylInput = Console.ReadLine();

            Passenger human = CheckIdentity(identitylInput);

            Console.WriteLine($"\r\nAccess Level - {human.AccessLevel}");

            while (true)
            {
                human.ShowTerminalCommands();
            }
        }


        static Passenger CheckIdentity(string identityInput)
        {
            
            switch (identityInput)
            {
                case "1":
                    return new Administrator();
                    
                case "2":
                    return new Worker();
                    
                case "3":
                    return new User();
                    break;
                default:
                    throw new FormatException("Incorrect input");
            }

        }

        
    }
}
