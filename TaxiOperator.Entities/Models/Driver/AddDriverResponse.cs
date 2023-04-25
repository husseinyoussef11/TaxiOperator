using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Entities.Models.Driver
{
    public class AddDriverResponse : GlobalResponse
    {
        public Guid id { get; set; }
    }
}
