using System;

namespace jsonreducer.data.Specifications
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _first;
        private readonly ISpecification<T> _second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException("first");
            }
            if (second == null)
            {
                throw new ArgumentNullException("second");
            }
            _first = first;
            _second = second;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return _first.IsSatisfiedBy(candidate) && _second.IsSatisfiedBy(candidate);
        }
    }
}