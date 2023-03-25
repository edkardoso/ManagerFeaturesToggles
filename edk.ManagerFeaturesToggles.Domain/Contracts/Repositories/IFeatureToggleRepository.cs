using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;
using edk.ManagerFeaturesToggles.Domain.Entities;

namespace edk.ManagerFeaturesToggles.Domain.Contracts.Repositories;

public interface IFeatureToggleRepository : IGenericRepository<FeatureToggle>
{
}