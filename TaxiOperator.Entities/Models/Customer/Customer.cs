using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Customer
{
    public class Customer
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public List<string> address { get; set; } 
        public string phonenumber { get; set; } 
        public bool isVip { get; set; } 
        public int vipratio { get; set; } 
    }
}
