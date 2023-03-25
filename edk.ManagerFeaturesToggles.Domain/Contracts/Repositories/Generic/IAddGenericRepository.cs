using edk.ManagerFeaturesToggles.Domain.Contracts.Common;

namespace edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;

public interface IAddGenericRepository<in TEntity> where TEntity : IEntity
{
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(IReadOnlyCollection<TEntity> entities);
}
