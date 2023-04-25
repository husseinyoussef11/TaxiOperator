using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Models.Branch;
using TaxiOperator.Repository.Branch;

namespace TaxiOperator.Business.Branch
{
    public class BranchBusiness : IBranchBusiness
    { 
        private IBranchRepository _branchRepository;

        public BranchBusiness(IBranchRepository BranchRepository)
        {
            _branchRepository = BranchRepository;
        }
        public AddBranchResponse Add(AddBranchRequest request)
        {
            AddBranchResponse response = new AddBranchResponse();
            response = _branchRepository.Add(request);
            response.statusCode.message ="Success"; 
            response.statusCode.code =0; 
            return response;
        }

        public ByIdBranchResponse ById(ByIdBranchRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteBranchResponse Delete(DeleteBranchRequest request)
        {
            DeleteBranchResponse response = new DeleteBranchResponse();
            response = _branchRepository.Delete(request);
            response.statusCode.message = "Success";
            response.statusCode.code = 0;
            return response;
        }

        public ListBranchResponse List(ListBranchRequest request)
        {
            ListBranchResponse response = new ListBranchResponse();
            response = _branchRepository.List(request);
            response.statusCode.message = "Success";
            response.statusCode.code = 0;
            return response;
        }

        public UpdateBranchResponse Update(UpdateBranchRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
