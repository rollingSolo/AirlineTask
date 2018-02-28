using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTask.Passengers
{
    public interface IPerson
    {   
        string Name { get; set; }
        string Surname { get; set; }
        string Nationality { get; set; }

        DateTime Birthday { get; }

        Sex sex { get; }

    }
}
