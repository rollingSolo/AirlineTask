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
        protected DateTime Birthday { get; }

        public abstract AccessLevels AccessLevel { get; }
        public virtual Sex Sex { get; set; }


        public Passenger()
        {

        }

        public Passenger(string name, string surName, string nationality, string birthday,int sex)
        {
            Name = name;
            Surname = surName;
            Nationality = nationality;
            Birthday = DateTime.Parse(birthday);
            Sex = (Sex)sex;
        }

    }
}
