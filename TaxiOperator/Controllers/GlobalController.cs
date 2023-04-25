using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiOperator.Business.Global;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GlobalController : ControllerBase
    {
        private readonly ILogger<GlobalController> _logger;
        private IGlobalBusiness _globalBusiness;
        public GlobalController(IGlobalBusiness GlobalBusiness, ILogger<GlobalController> logger)
        {
            _logger = logger;
            _globalBusiness = GlobalBusiness;
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public LoadDataResponse LoadData()
        {
            return _globalBusiness.LoadData();
        }
    }
}
