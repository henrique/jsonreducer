using NUnit.Framework;
using jsonreducer.data.Models;
using jsonreducer.data.Specifications;
using jsonreducer.data.Specifications.Extensions;

namespace jsonreducer.tests.Unit.Data.Specifications.Extensions
{
    [TestFixture]
    public class SpecificationExtensionTests
    {
        [Test]
        public void WhenCombiningSpecificationsThenResultIsAndSpecification()
        {
            var hasDrm = new HasDrmSpecification();
            var hasEps = new HasAtLeaseOneEpisodeSpecification();
            var sut = hasDrm.And(hasEps);
            Assert.IsInstanceOf<AndSpecification<TvShow>>(sut);
            Assert.IsTrue(sut.IsSatisfiedBy(new TvShow { Drm = true, EpisodeCount = 1 }));
        }
    }
}