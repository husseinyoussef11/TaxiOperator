using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Models.Branch;

namespace TaxiOperator.Business.Branch
{
    public interface IBranchBusiness
    {
        ListBranchResponse List(ListBranchRequest request);
        ByIdBranchResponse ById(ByIdBranchRequest request);
        AddBranchResponse Add(AddBranchRequest request);
        UpdateBranchResponse Update(UpdateBranchRequest request);
        DeleteBranchResponse Delete(DeleteBranchRequest request);
    }
}
