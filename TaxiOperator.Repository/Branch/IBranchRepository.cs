using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Models.Branch;

namespace TaxiOperator.Repository.Branch
{
    public interface IBranchRepository
    {
        AddBranchResponse Add(AddBranchRequest request);
        ListBranchResponse List(ListBranchRequest request);
        DeleteBranchResponse Delete(DeleteBranchRequest request);
    }
}
