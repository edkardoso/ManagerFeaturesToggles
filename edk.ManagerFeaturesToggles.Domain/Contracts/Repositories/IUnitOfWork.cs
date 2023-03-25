using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;

namespace edk.ManagerFeaturesToggles.Domain.Contracts.Repositories;

public interface IUnitOfWork
{
    Task<bool> CommitAsync();
    Task RollbackAsync();
    IRepositoryFactory Repository { get; }
}
