using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    public abstract class Passenger
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string Nationality { get; set; }
        protected string Passport { get; }
        protected DateTime Birthday { get; }
        protected Sex Sex { get; set; }
        protected Ticket ticket;
        public abstract AccessLevels AccessLevel { get; }


        public Passenger()
        {

        }

        public Passenger(string name, 
                        string surName, 
                        string nationality,
                        string passport, 
                        string birthday,
                        int sex,
                        string airClass,
                        double ticketPrice)
        {
            Name = name;
            Surname = surName;
            Nationality = nationality;
            Passport = passport;
            Birthday = DateTime.Parse(birthday);
            Sex = (Sex)sex;
            ticket = new Ticket(airClass, ticketPrice);
        }

        public abstract void ShowTerminalCommands();
        

        public class Ticket
        {
            public string Class { get; set; }
            public double Price { get; }

            public Ticket(string airClass,double ticketPrice)
            {
                Class = airClass;
                Price = ticketPrice;
            }
        }
    }
}
