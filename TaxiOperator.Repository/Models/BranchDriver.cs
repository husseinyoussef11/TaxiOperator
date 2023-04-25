using System;
using System.Collections.Generic;

namespace TaxiOperator.Models
{
    public partial class BranchDriver
    {
        public Guid IdBranchDriver { get; set; }
        public Guid IdBranch { get; set; }
        public Guid IdDriver { get; set; }
        public DateTime? Created { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? Updated { get; set; }
    }
}
