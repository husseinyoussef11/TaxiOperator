using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Simulator
{
    public class MonthlyLotteryRequest
    {
        [ValidationActivationLotteryDate]
        public string date { get; set; }
    }
    public class ValidationActivationLotteryDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var request = (MonthlyLotteryRequest)validationContext.ObjectInstance;

            DateTime dt;
            string[] formats = { "yyyy-MM" };
            if (!DateTime.TryParseExact(request.date, formats,
                            System.Globalization.CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out dt))
                return new ValidationResult("Invalid Parameter");
            else
                return ValidationResult.Success;

        }
    }
}
