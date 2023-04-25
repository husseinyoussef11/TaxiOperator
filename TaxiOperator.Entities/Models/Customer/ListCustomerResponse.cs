using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Entities.Models.Customer
{
    public class ListCustomerResponse : GlobalResponse
    {
        public List<Customer> customers { get; set; }
        public int totalCount { get; set; }

    }
}
