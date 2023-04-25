using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Models.TestModels
{
    public class PageDetails : GeneralDetails
    {
        public Guid IdPagesDetails { get; set; }
        public string Tool { get; set; }
        public string DataType { get; set; }
    }
}