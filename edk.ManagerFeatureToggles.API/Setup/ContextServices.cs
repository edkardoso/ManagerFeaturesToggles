using edk.ManagerFeatureToggles.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace edk.ManagerFeatureToggles.API.Setup
{
    public static class ContextServices
    {
        public static IServiceCollection AddContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<FeatureToggleDbContext>(options => options.UseLazyLoadingProxies().UseNpgsql(connectionString));

            return services;
        }
    }
}
