using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOperator.Entities.Common
{
    public enum StatusCodeValues
    {
        Success = 0,
        ServerError = 1,
        InvalidParameters = 2,
        NotLoggedIn = 3,
        InvalidEmailOrPassword = 4,
        NotAuthorized = 16,
        AccessDenied = 17
    }
}
