using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Customer
{
    public class AddCustomerRequest
    {
        [Required]
        public Guid? id { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string name { get; set; } 
        public List<string> address { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string phonenumber { get; set; } 
    }
}
