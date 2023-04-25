using System;
using System.Collections.Generic;

namespace TaxiOperator.Models
{
    public partial class BranchCab
    {
        public Guid IdBranchCab { get; set; }
        public Guid IdBranch { get; set; }
        public Guid IdCab { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
