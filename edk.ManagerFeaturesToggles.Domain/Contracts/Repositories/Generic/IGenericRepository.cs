using edk.ManagerFeaturesToggles.Domain.Contracts.Common;

namespace edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;

public interface IGenericRepository { }

public interface IGenericRepository<TEntity> :
     IReadGenericRepository<TEntity>
    , IAddGenericRepository<TEntity>
    , IUpdateGenericRepository<TEntity>
    , IDeleteGenericRepository<TEntity>
    , IGenericRepository
    where TEntity : IEntity
{ }
