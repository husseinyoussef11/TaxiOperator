using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;
using TaxiOperator.Entities.Models.Simulator;
using TaxiOperator.Repository.Simulator;

namespace TaxiOperator.Business.Simulator
{
    public class SimulatorBusiness : ISimulatorBusiness
    {
        private ISimulatorRepository _simulatorRepository;

        public SimulatorBusiness(ISimulatorRepository SimulatorRepository)
        {
            _simulatorRepository = SimulatorRepository;
        }

        public GlobalResponse AddMockData()
        {
            GlobalResponse response = new GlobalResponse();
            response = _simulatorRepository.AddMockData();
            if (response.statusCode.code == 0)
            {
                response.statusCode.message = "Success";
                response.statusCode.code = 0;
            }
            return response;
        }

        public CapDriverAssignResponse CapDriverAssign(CapDriverAssignRequest request)
        {
            CapDriverAssignResponse response = new CapDriverAssignResponse();
            response = _simulatorRepository.CapDriverAssign(request);
            if (response.statusCode.code == 0)
            {
                response.statusCode.message = "Success";
                response.statusCode.code = 0;
            }
            return response;
        }

        public ListCabsShiftsResponse ListCabsShifts(ListCabsShiftsRequest request)
        {
            throw new NotImplementedException(); 
        }

        public MonthlyLotteryResponse MonthlyLottery(MonthlyLotteryRequest request)
        {
            MonthlyLotteryResponse response = new MonthlyLotteryResponse();
            response = _simulatorRepository.MonthlyLottery(request);
            if (response.statusCode.code == 0)
            {
                response.statusCode.message = "Success";
                response.statusCode.code = 0;
            }
            return response;
        }

        public OrderResponse Order(OrderRequest request)
        {
            OrderResponse response = new OrderResponse();
            response = _simulatorRepository.Order(request);
            if (response.statusCode.code == 0)
            {
                response.statusCode.message = "Success";
                response.statusCode.code = 0;
            }
            return response;
        }

        public GlobalResponse RemoveMockData()
        {
            GlobalResponse response = new GlobalResponse();
            response = _simulatorRepository.RemoveMockData();
            if (response.statusCode.code == 0)
            {
                response.statusCode.message = "Success";
                response.statusCode.code = 0;
            }
            return response;
        }
    }
}
