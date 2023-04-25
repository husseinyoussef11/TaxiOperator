using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Common
{
    public class LoadDataResponse : GlobalResponse
    {
        public List<DropDown> areas { get; set; }
        public List<DropDown> drivers { get; set; }
        public List<DropDown> cabs { get; set; }
        public List<DropDown> customers { get; set; }
    }
}
