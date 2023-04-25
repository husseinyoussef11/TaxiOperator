using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiOperator.Business.Customer;
using TaxiOperator.Entities.Models.Customer;

namespace TaxiOperator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private ICustomerBusiness _customerBusiness;
        public CustomerController(ICustomerBusiness CustomerBusiness, ILogger<CustomerController> logger)
        {
            _logger = logger;
            _customerBusiness = CustomerBusiness;
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public ListCustomerResponse List(ListCustomerRequest request)
        {
            return _customerBusiness.List(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public ByIdCustomerResponse ById(ByIdCustomerRequest request)
        {
            return _customerBusiness.ById(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public AddCustomerResponse Add(AddCustomerRequest request)
        {
            return _customerBusiness.Add(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public UpdateCustomerResponse Update(UpdateCustomerRequest request)
        {
            return _customerBusiness.Update(request);
        }
        ///<summary> 
        ///Not Implemented
        ///</summary>
        ///<remarks>  
        ///</remarks>
        [HttpPost]
        public DeleteCustomerResponse Delete(DeleteCustomerRequest request)
        {
            return _customerBusiness.Delete(request);
        }
    }
}
