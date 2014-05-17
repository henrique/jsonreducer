using System.Collections.Generic;

namespace jsonreducer.web.Models
{
    public class JsonReducerQueryResult
    {
        public ICollection<TvShowSummary> Response { get; private set; }

        public JsonReducerQueryResult()
        {
            Response = new List<TvShowSummary>();
        }
    }
}