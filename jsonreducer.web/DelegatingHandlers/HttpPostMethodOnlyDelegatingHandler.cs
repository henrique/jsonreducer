using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using jsonreducer.web.Models;

namespace jsonreducer.web.DelegatingHandlers
{
    public class HttpPostMethodOnlyDelegatingHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Method != HttpMethod.Post)
            {
                var response = request.CreateResponse(HttpStatusCode.BadRequest, new JsonReducerUnsupportedMethodError());
                var tsc = new TaskCompletionSource<HttpResponseMessage>();
                tsc.SetResult(response);
                return tsc.Task;
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}