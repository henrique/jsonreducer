using jsonreducer.data.Models;

namespace jsonreducer.data.Specifications
{
    public class HasDrmSpecification : ISpecification<TvShow>
    {
        public bool IsSatisfiedBy(TvShow candidate)
        {
            return candidate.Drm;
        }
    }
}