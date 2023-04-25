using System;
using System.Collections.Generic;

namespace TaxiOperator.Models
{
    public partial class Customer
    {
        public Guid IdCustomer { get; set; }
        public string? Name { get; set; }
        public string? Phonenumber { get; set; }
        public bool? IsVip { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool? IsActive { get; set; }
        public string? Address { get; set; }
    }
}
