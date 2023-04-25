using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Driver
{
    public class AddDriverRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string name { get; set; }
        [ValidationActivationBirthDate]
        public string birthdate { get; set; }
        [Required]
        public Guid? idCab { get; set; }
    }
    public class ValidationActivationBirthDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var request = (AddDriverRequest)validationContext.ObjectInstance;

            DateTime dt;
            string[] formats = { "yyyy-MM-dd" };
            if (!DateTime.TryParseExact(request.birthdate, formats,
                            System.Globalization.CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out dt))
                return new ValidationResult("Invalid Parameter");
            else
                return ValidationResult.Success;

        }
    }
}
