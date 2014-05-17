using System.Collections.Generic;
using NUnit.Framework;
using jsonreducer.data.Models;
using jsonreducer.web.Controllers;
using jsonreducer.web.Models;

namespace jsonreducer.tests.Integration.Web.Controllers
{
    [TestFixture]
    public class JsonReducerControllerIntegrationTests
    {
        [Test]
        public void WhenReducingThenResultContainsOnlyMatchingShows()
        {
            var query = new JsonReducerQuery
                {
                    Payload = new List<TvShow>
                        {
                            new TvShow { Drm = true, EpisodeCount = 1 },
                            new TvShow { Drm = false, EpisodeCount = 1 },
                            new TvShow { Drm = true, EpisodeCount = 0 },
                        }
                };

            var sut = new JsonReducerController();
            var result = sut.Post(query);

            Assert.AreEqual(1, result.Response.Count);
        }
    }
}
