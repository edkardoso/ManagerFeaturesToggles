using System.Threading.Tasks;
using edk.ManagerFeaturesToggles.Domain.Contracts.Common;

namespace edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;

public interface IUpdateGenericRepository<in TEntity> where TEntity : IEntity
{
    Task UpdateAsync(TEntity entity);
}
