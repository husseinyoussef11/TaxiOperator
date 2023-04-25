using System;
using System.Collections.Generic;

namespace TaxiOperator.Models
{
    public partial class MonthlyLottery
    {
        public Guid IdMonthlyLottery { get; set; }
        public string? Date { get; set; }
        public Guid IdCustomer { get; set; }
        public DateTime? Created { get; set; }
    }
}
