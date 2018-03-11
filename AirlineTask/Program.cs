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
    
    
    //TODO: There is a single responsibility principle in OOP: one class should be responsible for one action. 
    //For example, your 'Passenger' class holds and returns information for passenger - it's the responsibity of the class.
    //It shouldn't simultenuosly write to the console. Please, reconsider all your classes using this principle.
    //I would encapsulate all logic that writes to console in one class. Other classes should delegate this operation to it.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hi, Olga!! Welcome to AirLine Terminal, " +
                              $"today {DateTime.Now} \r\n" +
                              $"Press Enter to continue");
            

            Console.ReadLine();

            Console.WriteLine(@"Enter your role:
                               0 - User
                               1 - Administrator
                               2 - Worker");

  
            AccessLevels identitylInput = (AccessLevels)int.Parse(Console.ReadLine());

            Passenger human = PassengersFactory.CheckIdentity(identitylInput);

            Console.WriteLine($"Your access level is {identitylInput}");

            while (true)
            {
                human.ShowTerminalCommands();
            }
        }

        

        
    }
}
