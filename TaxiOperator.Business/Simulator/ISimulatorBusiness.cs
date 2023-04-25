using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;
using TaxiOperator.Entities.Models.Simulator;

namespace TaxiOperator.Business.Simulator
{
    public interface ISimulatorBusiness
    {
        OrderResponse Order(OrderRequest request);
        CapDriverAssignResponse CapDriverAssign(CapDriverAssignRequest request);
        MonthlyLotteryResponse MonthlyLottery(MonthlyLotteryRequest request);
        ListCabsShiftsResponse ListCabsShifts(ListCabsShiftsRequest request);
        GlobalResponse AddMockData();
        GlobalResponse RemoveMockData();
    }
}
