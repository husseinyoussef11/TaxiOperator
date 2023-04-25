using System;
using System.Collections.Generic;

namespace TaxiOperator.Models
{
    public partial class Order
    {
        public Guid IdOrder { get; set; }
        public Guid IdCab { get; set; }
        public Guid IdDriver { get; set; }
        public Guid IdCustomer { get; set; }
        public string? Source { get; set; }
        public string? Destination { get; set; }
        public int? IdArea { get; set; }
        public DateTime? Created { get; set; }
        public int? IsCompleted { get; set; }
    }
}
