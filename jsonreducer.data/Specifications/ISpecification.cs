namespace jsonreducer.data.Specifications
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T candidate);
    }
}
