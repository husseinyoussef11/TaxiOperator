using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Customer
{
    public class DeleteCustomerRequest
    {
        public List<Guid> ids { get; set; } 
    }
}
