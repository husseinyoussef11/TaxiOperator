using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Branch
{
    public class AddBranchRequest
    { 
        [Required(AllowEmptyStrings = false)]
        public string name { get; set; }
        [Required(AllowEmptyStrings = false)] 
        public string address { get; set; } 
        public Guid idArea { get; set; } 
        public List<Guid> drivers { get; set; }
        public List<Guid> cabs { get; set; }
        public List<Guid> customers { get; set; }
    }
}
