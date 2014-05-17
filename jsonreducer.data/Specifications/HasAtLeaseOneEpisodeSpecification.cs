using jsonreducer.data.Models;

namespace jsonreducer.data.Specifications
{
    public class HasAtLeaseOneEpisodeSpecification : ISpecification<TvShow>
    {
        public bool IsSatisfiedBy(TvShow candidate)
        {
            return candidate.EpisodeCount > 0;
        }
    }
}