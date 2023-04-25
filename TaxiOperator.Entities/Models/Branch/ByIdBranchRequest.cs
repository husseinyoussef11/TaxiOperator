using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Branch
{
    public class ByIdBranchRequest
    {
        [Required]
        public Guid? id { get; set; }
    }
}
