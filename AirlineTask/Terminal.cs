using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineTask.Flights;
using AirlineTask.Passengers;

namespace AirlineTask
{
    class Terminal
    {

        private List<Flight> flights = new List<Flight>()
        {
            new Flight("2008-05-01T07:34:42-5:00",
                       "2008-05-01T07:34:42-5:00",
                       "NewYork",
                       "45693",
                       "9B",
                       "South",
                       7)
            
        };







        public  void PrintFlightsInfo()
        {
            foreach (var item in flights)
            {
                item.GetFlightInfo();
            }
        }

        
        
    }


    
}
