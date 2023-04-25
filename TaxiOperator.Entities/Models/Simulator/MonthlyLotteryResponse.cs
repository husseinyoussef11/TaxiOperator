using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Entities.Models.Simulator
{
    public class MonthlyLotteryResponse : GlobalResponse
    {
        public Models.Customer.Customer customer { get; set; }
    }
}
