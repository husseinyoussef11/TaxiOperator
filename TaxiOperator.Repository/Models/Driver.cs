using System;
using System.Collections.Generic;

namespace TaxiOperator.Models
{
    public partial class Driver
    {
        public Guid IdDriver { get; set; }
        public string? Name { get; set; }
        public string? BirthDate { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool? IsActive { get; set; }
    }
}
