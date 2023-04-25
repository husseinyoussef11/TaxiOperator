using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Cab
{
    public class AddCabRequest
    {
        [Required]
        public Guid? id { get; set; }
        [Required(AllowEmptyStrings = false)]  
        public string type { get; set; }
        [Required(AllowEmptyStrings = false)] 
        public string year { get; set; }
        [Required(AllowEmptyStrings = false)]  
        public string model { get; set; }
        [Required(AllowEmptyStrings = false)] 
        public string enginesize { get; set; } 
    }
}
