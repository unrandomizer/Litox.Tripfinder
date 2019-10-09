using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Litox.Tripfinder
{
    public class Airport
    {
        public int ID { get; set; }
        [Key]
        public string IATA { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Country { get; set; }
    }
}
