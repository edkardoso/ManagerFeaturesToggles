using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories;
using edk.ManagerFeaturesToggles.Domain.Entities;

namespace edk.ManagerFeatureToggles.Infra.Data.Repositories;

public class FeatureToggleRepository : GenericRepository<FeatureToggle>, IFeatureToggleRepository
{
    public FeatureToggleRepository(FeatureToggleDbContext dbContext) : base(dbContext)
    {
    }
}
