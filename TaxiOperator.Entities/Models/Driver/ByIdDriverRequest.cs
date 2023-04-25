using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Driver
{
    public class ByIdDriverRequest
    {
        [Required]
        public Guid? id { get; set; }
    }
}
