using System;
using System.Collections.Generic;
using System.Text;

namespace Litox.Tripfinder
{
    public class Connection
    {
        public int ID { get; set; }
        public virtual Airport DepartureAirport { get; set; }
        public virtual Airport ArrivalAirport { get; set; }

    }
}
