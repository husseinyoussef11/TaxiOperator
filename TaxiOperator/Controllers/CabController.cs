using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiOperator.Business.Cab;
using TaxiOperator.Entities.Models.Cab;

namespace TaxiOperator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CabController : ControllerBase
    {
        private readonly ILogger<CabController> _logger;
        private ICabBusiness _cabBusiness;
        public CabController(ICabBusiness CabBusiness, ILogger<CabController> logger)
        {
            _logger = logger;
            _cabBusiness = CabBusiness;
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public ListCabResponse List(ListCabRequest request)
        {
            return _cabBusiness.List(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public ByIdCabResponse ById(ByIdCabRequest request)
        {
            return _cabBusiness.ById(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public AddCabResponse Add(AddCabRequest request)
        {
            return _cabBusiness.Add(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public UpdateCabResponse Update(UpdateCabRequest request)
        {
            return _cabBusiness.Update(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public DeleteCabResponse Delete(DeleteCabRequest request)
        {
            return _cabBusiness.Delete(request);
        }
    }
}
