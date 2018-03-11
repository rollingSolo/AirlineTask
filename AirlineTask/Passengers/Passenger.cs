using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    public class Passenger
    {
        public string Name { get; }
        public string Surname { get; }
        protected string Nationality { get; }
        public string Passport { get; }
        protected DateTime Birthday { get; }
        protected Sex Sex { get; }
        protected Ticket ticket;
        

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

        public virtual string GetPassengerInfo()
        {
            return String.Format($"Name: {this.Name}\r\n" +
                              $"Last Name: {this.Surname}\r\n" +
                              $"Passport: {this.Passport}\r\n" +
                              $"Airplane Class: {this.ticket.Class}\r\n"+
                              $"Birthday: {this.Birthday}\r\n" +
                              $"Nationality: {this.Nationality}\r\n" +
                              $"Sex: {this.Sex}\r\n");
        }
        public virtual void ShowTerminalCommands()
        {

        }
        

        
        
    }
}
