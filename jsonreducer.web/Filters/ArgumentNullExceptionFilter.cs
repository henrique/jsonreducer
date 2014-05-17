using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using jsonreducer.web.Models;

namespace jsonreducer.web.Filters
{
    public class ArgumentNullExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if (context.Exception is ArgumentNullException)
            {
                context.Response = context.Request.CreateResponse(HttpStatusCode.BadRequest, new JsonReducerError(context.Exception));
            }
        }
    }
}