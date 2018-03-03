using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Flights
{
   public enum FlightStatus
    {
        CheckIn,
        GateClosed,
        Arrived,
        Departure,
        Unknown,
        Canceled,
        Expected,
        Delay,
        InFlight
    }
}
