using NUnit.Framework;
using jsonreducer.data.Models;
using jsonreducer.data.Specifications;

namespace jsonreducer.tests.Unit.Data.Specifications
{
    [TestFixture]
    public class HasAtLeaseOneEpisodeSpecificationTests
    {
        protected HasAtLeaseOneEpisodeSpecification SubjectUnderTest { get; private set; }

        [SetUp]
        public void SetUp()
        {
            SubjectUnderTest = new HasAtLeaseOneEpisodeSpecification();
        }

        [Test]
        public void WhenTvShowHasEpisodeCountGreaterThanZeroThenResultIsTrue()
        {
            var tvShow = new TvShow { EpisodeCount = 1 };
            Assert.IsTrue(SubjectUnderTest.IsSatisfiedBy(tvShow));
        }

        [Test]
        public void WhenTvShowHasEpisodeCountLessThanOneThenResultIsFalse()
        {
            var tvShow = new TvShow { EpisodeCount = 0 };
            Assert.IsFalse(SubjectUnderTest.IsSatisfiedBy(tvShow));
        }
    }
}