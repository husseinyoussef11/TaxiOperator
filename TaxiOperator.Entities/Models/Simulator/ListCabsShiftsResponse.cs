using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Entities.Models.Simulator
{
    public class ListCabsShiftsResponse : GlobalResponse
    {
        public List<CabDriver> cabDrivers { get; set; }
    }
    public class CabDriver{
        public Models.Cab.Cab cab { get; set; }
        public Models.Driver.Driver driver { get; set; }
        public int idShift { get; set; }///1 day , 2 night
    }
}
