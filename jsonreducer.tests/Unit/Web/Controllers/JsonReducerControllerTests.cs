using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using jsonreducer.data.Models;
using jsonreducer.data.Specifications;
using jsonreducer.web.Controllers;
using jsonreducer.web.Models;

namespace jsonreducer.tests.Unit.Web.Controllers
{
    [TestFixture]
    public class JsonReducerControllerTests
    {
        [Test]
        public void WhenReducingThenResultContainsOnlyMatchingShows()
        {
            var specMock = Substitute.For<ISpecification<TvShow>>();
            specMock.IsSatisfiedBy(Arg.Any<TvShow>()).Returns(true);

            var query = new JsonReducerQuery
                {
                    Payload = new List<TvShow>
                        {
                            new TvShow()
                        }
                };

            var sut = new JsonReducerController(specMock);
            var result = sut.Post(query);

            Assert.AreEqual(1, result.Response.Count);
        }
    }
}
