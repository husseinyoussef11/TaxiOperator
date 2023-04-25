using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Models.Cab;

namespace TaxiOperator.Business.Cab
{
    public interface ICabBusiness
    {
        ListCabResponse List(ListCabRequest request);
        ByIdCabResponse ById(ByIdCabRequest request);
        AddCabResponse Add(AddCabRequest request);
        UpdateCabResponse Update(UpdateCabRequest request);
        DeleteCabResponse Delete(DeleteCabRequest request);
    }
}
