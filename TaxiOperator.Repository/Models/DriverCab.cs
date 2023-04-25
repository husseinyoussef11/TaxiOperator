using System;
using System.Collections.Generic;

namespace TaxiOperator.Models
{
    public partial class DriverCab
    {
        public Guid IdDriverCab { get; set; }
        public Guid IdDriver { get; set; }
        public Guid IdCab { get; set; }
        public string? DateAssigned { get; set; }
        public DateTime? Created { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? Updated { get; set; }
    }
}
