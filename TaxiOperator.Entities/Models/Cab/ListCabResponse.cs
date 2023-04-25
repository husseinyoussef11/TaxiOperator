using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Entities.Models.Cab
{
    public class ListCabResponse :  GlobalResponse
    {
        public List<Cab> cabs { get; set; }
        public int totalCount { get; set; } 
    }
}
