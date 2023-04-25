using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using TaxiOperator.Entities.Common;

namespace TaxiOperator.Filter
{
    public class ModelValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string actionName = filterContext.ActionDescriptor.DisplayName.ToLower();
            if (!filterContext.ModelState.IsValid)
            {
                string errors = string.Empty;
                foreach (var state in filterContext.ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        errors += string.Join(",", error.ErrorMessage);
                    }
                }
                //errors = string.Empty.Trim(',');
                ContentResult content = new ContentResult();
                content.ContentType = "application/json";

                if (actionName.Contains("export"))
                    content.Content = null;
                else
                    content.Content = JsonConvert.SerializeObject(new GlobalResponse
                    {
                        statusCode = new StatusCode
                        {
                            code = (int)StatusCodeValues.InvalidParameters,
                            message = errors
                        }
                    });
                //content.Content = ResourcesManager.getStatusCodeJson(Entities.Language.English, ServiceManagment.Entities.Common.StatusCodeValues.InvalidParameters);

                filterContext.Result = content;
                base.OnActionExecuting(filterContext);
            }
        }
    }
}