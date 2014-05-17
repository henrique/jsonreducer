using System;
using System.Web.Http;
using jsonreducer.data.Models;
using jsonreducer.data.Specifications;
using jsonreducer.data.Specifications.Extensions;
using jsonreducer.web.Extensions;
using jsonreducer.web.Models;

namespace jsonreducer.web.Controllers
{
    public class JsonReducerController : ApiController
    {
        private readonly ISpecification<TvShow> _tvShowSpecification;

        public JsonReducerController()
        {
            var hasDrmSpec = new HasDrmSpecification();
            var hasEpisodes = new HasAtLeaseOneEpisodeSpecification();
            _tvShowSpecification = hasDrmSpec.And(hasEpisodes);
        }

        public JsonReducerController(ISpecification<TvShow> tvShowSpecification)
        {
            if (tvShowSpecification == null)
            {
                throw new ArgumentNullException("tvShowSpecification");
            }
            _tvShowSpecification = tvShowSpecification;
        }

        [HttpPost]
        public JsonReducerQueryResult Post(JsonReducerQuery jsonReducerQuery)
        {
            if (jsonReducerQuery == null)
            {
                throw new ArgumentNullException("jsonReducerQuery");
            }

            var result = new JsonReducerQueryResult();

            foreach (var tvShow in jsonReducerQuery.Payload)
            {
                if (_tvShowSpecification.IsSatisfiedBy(tvShow))
                {
                    result.Response.Add(tvShow.ToSummary());
                }
            }

            return result;
        }
    }
}