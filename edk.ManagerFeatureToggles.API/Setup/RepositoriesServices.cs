using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories;
using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;
using edk.ManagerFeatureToggles.Infra.Data.Repositories;

namespace edk.ManagerFeatureToggles.API.Setup
{
    public static class RepositoriesServices
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IRepositoryFactory, RepositoryFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IFeatureToggleRepository, FeatureToggleRepository>();

            return services;
        }
    }
}
