using System;
using System.Threading.Tasks;
using edk.ManagerFeaturesToggles.Domain.Contracts.Common;

namespace edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;

public interface IDeleteGenericRepository<in TEntity> where TEntity : IEntity
{
    Task DeleteByIdAsync(Guid id);
    Task DeleteAsync(TEntity entity);

}
