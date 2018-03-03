using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    class Administrator : Passenger
    {
        public override AccessLevels AccessLevel
        {
            get
            {
                return AccessLevels.Administrator;
            }
        }

        public override void ShowTerminalCommands()
        {
            throw new NotImplementedException();
        }
    }
}
