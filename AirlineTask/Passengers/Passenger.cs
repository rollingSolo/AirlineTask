using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    public abstract class Passenger
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        protected string Nationality { get; set; }
        public string Passport { get; }
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
            this.Name = name;
            this.Surname = surName;
            this.Nationality = nationality;
            this.Passport = passport;
            this.Birthday = DateTime.Parse(birthday);
            this.Sex = (Sex)sex;
            this.ticket = new Ticket(airClass, ticketPrice);
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name}\r\n" +
                              $"Last Name: {this.Surname}\r\n" +
                              $"Passport: {this.Passport}\r\n" +
                              $"Airplane Class: {this.ticket.Class}\r\n"+
                              $"Birthday: {this.Birthday}\r\n" +
                              $"Nationality: {this.Nationality}\r\n" +
                              $"Sex: {this.Sex}\r\n");
        }
        public abstract void ShowTerminalCommands();
        

        public class Ticket
        {
            public string Class { get; set; }
            public double Price { get; }

            public Ticket(string airClass,double ticketPrice)
            {
                this.Class = airClass;
                this.Price = ticketPrice;
            }
        }
    }
}
