using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using jsonreducer.web.Models;

namespace jsonreducer.web.Filters
{
    public class ModelValidationActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.BadRequest,
                                                                     new JsonReducerError(actionContext.ModelState));
            }
        } 
    }
}