using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Branch
{
    public class DeleteBranchRequest
    {
        public List<Guid> ids { get; set; }
    }
}
