using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    class PassengersFactory
    {
        public static Passenger CheckIdentity(AccessLevels accessLevel)
        {

            switch ((int)accessLevel)
            {
                case 0:
                    return new User();

                case 1:
                    return new Administrator();

                case 2:
                    return new Worker();
                
                default:
                    throw new FormatException("Incorrect input");
            }

        }
    }
}
