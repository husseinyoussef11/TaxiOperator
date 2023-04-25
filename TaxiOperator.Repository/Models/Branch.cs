using System;
using System.Collections.Generic;

namespace TaxiOperator.Models
{
    public partial class Branch
    {
        public Guid IdBranch { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public Guid? IdArea { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool? IsActive { get; set; }
    }
}
