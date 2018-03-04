using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    public class Administrator : Passenger
    {
        public override AccessLevels AccessLevel
        {
            get
            {
                return AccessLevels.Administrator;
            }
        }

        public Administrator()
        {

        }
        public Administrator(string name,
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
        public override void ShowTerminalCommands()
        {
            throw new NotImplementedException();
        }
    }
}
