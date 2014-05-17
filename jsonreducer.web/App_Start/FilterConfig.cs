using System.Web.Http.Filters;
using jsonreducer.web.Filters;

namespace jsonreducer.web.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(HttpFilterCollection filters)
        {
            filters.Add(new ArgumentNullExceptionFilter());
            filters.Add(new ModelValidationActionFilter());
        }
    }
}