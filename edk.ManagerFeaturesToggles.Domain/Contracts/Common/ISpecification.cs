namespace edk.ManagerFeaturesToggles.Domain.Contracts.Common
{
    public interface ISpecification<in T> where T : IEntity
    {
        bool IsISpecification(T entity);
    }
}
