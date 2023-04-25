using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Entities.Models.Branch
{
    public class ListBranchResponse : GlobalResponse
    {
        public List<Branch> branches { get; set; }
        public int totalCount { get; set; }
    }
}
