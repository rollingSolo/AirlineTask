using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    class User : Passenger
    {
        public override AccessLevels AccessLevel
        {
            get
            {
                return AccessLevels.User;
            }
        }
    }
}
