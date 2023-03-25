using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories;
using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;

namespace edk.ManagerFeatureToggles.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FeatureToggleDbContext _dbContext;

        public UnitOfWork(FeatureToggleDbContext dbContext, IRepositoryFactory repositoryFactory)
        {
            _dbContext = dbContext;
            Repository = repositoryFactory;
        }

        public async Task<bool> CommitAsync() => await _dbContext.SaveChangesAsync().ConfigureAwait(false) > 0;

        public async Task RollbackAsync() => await Task.CompletedTask.ConfigureAwait(false);

        public IRepositoryFactory Repository { get; }
    }
}
