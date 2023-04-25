using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Simulator
{
    public class OrderRequest
    {
        [Required]
        public Guid idCab { get; set; }
        [Required] 
        public Guid idDriver { get; set; }
        [Required]
        public Guid idCustomer { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string source { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string destination { get; set; }
        public int idArea { get; set; }
        [ValidationActivationOrderDate]
        public string date { get; set; }
    }
    public class ValidationActivationOrderDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var request = (OrderRequest)validationContext.ObjectInstance;

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
