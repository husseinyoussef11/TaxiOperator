using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Customer
{
    public class UpdateCustomerRequest
    {  
        public string name { get; set; }
        public List<string> address { get; set; } 
        public string phonenumber { get; set; }
    }
}
