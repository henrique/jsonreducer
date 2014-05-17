using NUnit.Framework;
using jsonreducer.data.Models;
using jsonreducer.data.Specifications;

namespace jsonreducer.tests.Unit.Data.Specifications
{
    [TestFixture]
    public class HasDrmSpecificationTests
    {
        protected HasDrmSpecification SubjectUnderTest { get; private set; }

        [SetUp]
        public void SetUp()
        {
            SubjectUnderTest = new HasDrmSpecification();
        }

        [Test]
        public void WhenTvShowHasDrmThenResultIsTrue()
        {
            var tvShow = new TvShow { Drm = true };
            Assert.IsTrue(SubjectUnderTest.IsSatisfiedBy(tvShow));
        }

        [Test]
        public void WhenTvShowDoesNotHaveDrmThenResultIsFalse()
        {
            var tvShow = new TvShow { Drm = false };
            Assert.IsFalse(SubjectUnderTest.IsSatisfiedBy(tvShow));
        }
    }
}
