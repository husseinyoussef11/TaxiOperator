using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Business.Global
{
    public interface IGlobalBusiness
    {
        LoadDataResponse LoadData();
    }
}
