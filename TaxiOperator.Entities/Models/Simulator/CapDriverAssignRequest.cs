using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Simulator
{
    public class CapDriverAssignRequest
    {
        [Required]
        public Guid idCab { get; set; }
        [Required]
        public Guid idDriver { get; set; }
        [ValidationActivationDate]
        public string date { get; set; }
        [Range(1,2)]
        public int idShift { get; set; }
    }
    public class ValidationActivationDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var request = (CapDriverAssignRequest)validationContext.ObjectInstance;

            DateTime dt;
            string[] formats = { "yyyy-MM-dd" };
            if (!DateTime.TryParseExact(request.date, formats,
                            System.Globalization.CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out dt))
                return new ValidationResult("Invalid Parameter");
            else
                return ValidationResult.Success;

        }
    }
}
