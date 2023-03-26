using System.Linq.Expressions;
using edk.ManagerFeaturesToggles.Domain.Contracts.Common;
using edk.Tools.Common;

namespace edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;
public interface IReadGenericRepository<TEntity> where TEntity : IEntity
{
    Task<Option<TEntity>> GetByIdAsync(Guid id);
    Task<Option<TEntity>> FirstOrDefaultAsync();
    Task<Option<TEntity>> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter);
    Task<Option<TEntity>> SingleAsync(Expression<Func<TEntity, bool>> filter);
    Task<Option<List<TEntity>>> SearchAsync(Expression<Func<TEntity, bool>> filter);
}
