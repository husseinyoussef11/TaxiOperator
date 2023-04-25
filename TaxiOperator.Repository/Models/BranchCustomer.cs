using System;
using System.Collections.Generic;

namespace TaxiOperator.Models
{
    public partial class BranchCustomer
    {
        public Guid IdBranchCustomer { get; set; }
        public Guid IdBranch { get; set; }
        public Guid IdCustomer { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
