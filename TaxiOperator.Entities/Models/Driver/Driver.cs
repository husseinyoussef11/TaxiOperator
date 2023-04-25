using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Driver
{
    public class Driver
    {
        public Guid id { get; set; }
        public string name { get; set; } 
        public string birthdate { get; set; }
        public string image { get; set; }
        public Models.Cab.Cab cab { get; set; }
    }
}
