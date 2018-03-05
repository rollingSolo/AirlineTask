//TODO: Remove unused 'using's (here and in all files).
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
    //TODO: Better not to rename Program class. Though the name you chose is very intuitive, anyone will be looking for 'Program' file first.
    //TODO: I would put to 'Passengers' folder only the classes that are passengers. Otherwise classes location is not very obvious.
    //TODO: There is a single responsibility principle in OOP: one class should be responsible for one action. 
    //For example, your 'Passenger' class holds and returns information for passenger - it's the responsibity of the class.
    //It shouldn't simultenuosly write to the console. Please, reconsider all your classes using this principle.
    //I would encapsulate all logic that writes to console in one class. Other classes should delegate this operation to it.
    class Executor
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hi, Olga!! Welcome to AirLine Terminal, " +
                              $"today {DateTime.Now} \r\n" +
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

        //TODO: this method could be moved to a separate class. By the way, it is the implementation of the factory method pattern :)
        //Therefore, you can call it 'PassengerFactory' (or any other factory based on what class it will return).
        //And use AccessLevel instead of string as an argument.
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
                    break;//TODO: remove the compilator warning
                default:
                    throw new FormatException("Incorrect input");
            }

        }

        
    }
}
