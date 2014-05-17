using jsonreducer.data.Models;
using jsonreducer.web.Models;

namespace jsonreducer.web.Application.Extensions
{
    public static class TvShowExtensions
    {
        public static TvShowSummary ToSummary(this TvShow tvShow)
        {
            return new TvShowSummary
                {
                    Image = tvShow.Image != null ? tvShow.Image.ShowImage : null,
                    Slug = tvShow.Slug,
                    Title = tvShow.Title
                };
        }
    }
}