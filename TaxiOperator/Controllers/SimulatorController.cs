using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiOperator.Business.Simulator;
using TaxiOperator.Entities.Common;
using TaxiOperator.Entities.Models.Simulator;

namespace TaxiOperator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SimulatorController : ControllerBase
    {
        private readonly ILogger<SimulatorController> _logger;
        private ISimulatorBusiness _simulatorBusiness;
        public SimulatorController(ISimulatorBusiness SimulatorBusiness, ILogger<SimulatorController> logger)
        {
            _logger = logger;
            _simulatorBusiness = SimulatorBusiness;
        }
        ///<summary> 
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public OrderResponse Order(OrderRequest request)
        {
            return _simulatorBusiness.Order(request);
        }
        [HttpPost]
        public CapDriverAssignResponse CapDriverAssign(CapDriverAssignRequest request)
        {
            return _simulatorBusiness.CapDriverAssign(request);
        }
        [HttpPost]
        public MonthlyLotteryResponse MonthlyLottery(MonthlyLotteryRequest request)
        {
            return _simulatorBusiness.MonthlyLottery(request);
        }
        [HttpPost]
        public ListCabsShiftsResponse ListCabsShifts(ListCabsShiftsRequest request)
        {
            return _simulatorBusiness.ListCabsShifts(request);
        }
        [HttpPost]
        public GlobalResponse AddMockData()
        {
            return _simulatorBusiness.AddMockData();
        }
        [HttpPost]
        public GlobalResponse RemoveMockData()
        {
            return _simulatorBusiness.RemoveMockData();
        }
    }
}
