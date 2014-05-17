using System;
using NUnit.Framework;
using jsonreducer.data.Models;
using jsonreducer.web.Application.Extensions;

namespace jsonreducer.tests.Unit.Web.Application.Extensions
{
    [TestFixture]
    public class TvShowExtensionsTests
    {
        [Test]
        public void WhenTvShowHasAllMappedPropertiesThenResultIsTvShowSummary()
        {
            var tvShow = new TvShow
            {
                Image = new Image
                {
                    ShowImage = new Uri("http://catchup.ninemsn.com.au/img/jump-in/shows/Thunderbirds_1280.jpg")
                },
                Slug = "show/thunderbirds",
                Title = "Thunderbirds"
            };

            var sut = tvShow.ToSummary();

            Assert.AreEqual(tvShow.Title, sut.Title);
            Assert.AreEqual(tvShow.Slug, sut.Slug);
            Assert.AreEqual(tvShow.Image.ShowImage, sut.Image);
        }

        [Test]
        public void WhenTvShowDoesNotHaveImageThenResultPropertyIsNull()
        {
            var tvShow = new TvShow
            {
                Slug = "show/thunderbirds",
                Title = "Thunderbirds"
            };

            var sut = tvShow.ToSummary();

            Assert.AreEqual(tvShow.Title, sut.Title);
            Assert.AreEqual(tvShow.Slug, sut.Slug);
            Assert.IsNull(sut.Image);
        }
    }
}