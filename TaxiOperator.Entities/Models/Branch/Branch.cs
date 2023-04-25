using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Branch
{
    public class Branch
    {
        public Guid id { get; set; } 
        public string name { get; set; } 
        public string address { get; set; } 
        public Guid idArea { get; set; }
        public string area { get; set; }
        public List<Models.Driver.Driver> drivers { get; set; }
        public List<Models.Cab.Cab> cabs { get; set; }
        public List<Models.Customer.Customer> customers { get; set; }
    }
}
