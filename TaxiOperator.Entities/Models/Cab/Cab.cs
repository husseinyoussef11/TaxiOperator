using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Cab
{
    public class Cab
    {
        public Guid id { get; set; }
        public string type { get; set; }
        public string year { get; set; } 
        public string model { get; set; } 
        public string enginesize { get; set; } 
        public string image { get; set; } 
    }
}
