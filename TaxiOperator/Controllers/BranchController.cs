using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiOperator.Business.Branch;
using TaxiOperator.Entities.Models.Branch;

namespace TaxiOperator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly ILogger<BranchController> _logger;
        private IBranchBusiness _branchBusiness; 
        public BranchController(IBranchBusiness BranchBusiness, ILogger<BranchController> logger)
        {
            _logger = logger;
            _branchBusiness = BranchBusiness;
        }
        ///<summary> 
        ///Working
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public ListBranchResponse List(ListBranchRequest request)
        { 
            return _branchBusiness.List(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public ByIdBranchResponse ById(ByIdBranchRequest request)
        {
            return _branchBusiness.ById(request);
        }
        ///<summary> 
        ///Working
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public AddBranchResponse Add(AddBranchRequest request)
        {
            return _branchBusiness.Add(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public UpdateBranchResponse Update(UpdateBranchRequest request)
        {
            return _branchBusiness.Update(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public DeleteBranchResponse Delete(DeleteBranchRequest request)
        {
            return _branchBusiness.Delete(request);
        }
    }
}
