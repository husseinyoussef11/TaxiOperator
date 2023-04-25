using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Entities.Models.Driver
{
    public class ListDriverResponse: GlobalResponse
    {
        public List<Driver> drivers { get; set; }
        public int totalCount { get; set; }

    }
}
