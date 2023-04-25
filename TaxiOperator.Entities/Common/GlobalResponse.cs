using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Common
{
    public class GlobalResponse
    {
        public StatusCode statusCode { get; set; } = new StatusCode();
    }
}
