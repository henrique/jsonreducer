using System;
using NUnit.Framework;
using jsonreducer.data.Models;
using jsonreducer.data.Specifications;

namespace jsonreducer.tests.Unit.Data.Specifications
{
    [TestFixture]
    public class AndSpecificationTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhenFirstSpecificationIsNullThenException()
        {
#pragma warning disable 168
            var sut = new AndSpecification<TvShow>(null, null);
#pragma warning restore 168
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhenSecondSpecificationIsNullThenException()
        {
#pragma warning disable 168
            var sut = new AndSpecification<TvShow>(new HasAtLeaseOneEpisodeSpecification(), null);
#pragma warning restore 168
        }

        [Test]
        public void WhenSpecificationsAreDefinedThenResultIsAndSpecification()
        {
            var hasDrm = new HasDrmSpecification();
            var hasEps = new HasAtLeaseOneEpisodeSpecification();
            var sut = new AndSpecification<TvShow>(hasDrm, hasEps);

            Assert.IsInstanceOf<AndSpecification<TvShow>>(sut);
            Assert.IsTrue(sut.IsSatisfiedBy(new TvShow { Drm = true, EpisodeCount = 1 }));
        }
    }
}