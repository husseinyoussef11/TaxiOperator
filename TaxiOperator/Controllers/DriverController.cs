using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiOperator.Business.Driver;
using TaxiOperator.Entities.Models.Driver;

namespace TaxiOperator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly ILogger<DriverController> _logger;
        private IDriverBusiness _driverBusiness;
        public DriverController(IDriverBusiness DriverBusiness, ILogger<DriverController> logger)
        {
            _logger = logger;
            _driverBusiness = DriverBusiness;
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public ListDriverResponse List(ListDriverRequest request)
        {
            return _driverBusiness.List(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public ByIdDriverResponse ById(ByIdDriverRequest request)
        {
            return _driverBusiness.ById(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public AddDriverResponse Add(AddDriverRequest request)
        {
            return _driverBusiness.Add(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public UpdateDriverResponse Update(UpdateDriverRequest request)
        {
            return _driverBusiness.Update(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public DeleteDriverResponse Delete(DeleteDriverRequest request)
        {
            return _driverBusiness.Delete(request);
        }
    }
}
