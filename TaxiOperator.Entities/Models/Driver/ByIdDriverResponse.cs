using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Entities.Models.Driver
{
    public class ByIdDriverResponse : GlobalResponse
    {
        public Driver driver { get; set; }
    }
}
