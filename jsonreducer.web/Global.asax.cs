using System;
using System.Web;
using System.Web.Http;
using jsonreducer.web.App_Start;

namespace jsonreducer.web
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            WebApiConfig.ConfigureApi(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalConfiguration.Configuration.Filters);
        }

        protected void Application_PreSendRequestHeaders(object sender, EventArgs e)
        {
            var app = sender as HttpApplication;
            if (app == null || !app.Request.IsLocal || app.Context == null)
                return;

            var headers = app.Context.Response.Headers;
            headers.Remove("Server");
        }
    }
}