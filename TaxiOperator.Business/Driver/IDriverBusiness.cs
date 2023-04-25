using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Models.Driver;

namespace TaxiOperator.Business.Driver
{
    public interface IDriverBusiness
    {
        ListDriverResponse List(ListDriverRequest request);
        ByIdDriverResponse ById(ByIdDriverRequest request);
        AddDriverResponse Add(AddDriverRequest request);
        UpdateDriverResponse Update(UpdateDriverRequest request);
        DeleteDriverResponse Delete(DeleteDriverRequest request);

    }
}
