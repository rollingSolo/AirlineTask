using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    public class Ticket
    {
        public string Class { get; }
        public double Price { get; }

        public Ticket(string airClass, double ticketPrice)
        {
            this.Class = airClass;
            this.Price = ticketPrice;
        }
    }
}
