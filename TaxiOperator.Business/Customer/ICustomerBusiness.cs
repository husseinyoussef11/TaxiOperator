using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOperator.Entities.Models.Customer;

namespace TaxiOperator.Business.Customer
{
    public interface ICustomerBusiness
    {
        ListCustomerResponse List(ListCustomerRequest request);
        ByIdCustomerResponse ById(ByIdCustomerRequest request);
        AddCustomerResponse Add(AddCustomerRequest request);
        UpdateCustomerResponse Update(UpdateCustomerRequest request);
        DeleteCustomerResponse Delete(DeleteCustomerRequest request);

    }
}
