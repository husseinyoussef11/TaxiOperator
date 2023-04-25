using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.Cab
{
    public class DeleteCabRequest
    {
        public List<Guid> ids { get; set; }
    }
}
