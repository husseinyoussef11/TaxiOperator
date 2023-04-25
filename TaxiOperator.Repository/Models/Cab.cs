using System;
using System.Collections.Generic;

namespace TaxiOperator.Models
{
    public partial class Cab
    {
        public Guid IdCab { get; set; }
        public string? Type { get; set; }
        public string? Year { get; set; }
        public string? Model { get; set; }
        public string? Enginesize { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool? IsActive { get; set; }
    }
}
