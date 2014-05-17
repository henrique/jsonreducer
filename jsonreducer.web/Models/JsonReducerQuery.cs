using System.Collections.Generic;
using jsonreducer.data.Models;

namespace jsonreducer.web.Models
{
    public class JsonReducerQuery
    {
        public IEnumerable<TvShow> Payload { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public int TotalRecords { get; set; }

        public JsonReducerQuery()
        {
            Payload = new List<TvShow>();
        }
    }
}
