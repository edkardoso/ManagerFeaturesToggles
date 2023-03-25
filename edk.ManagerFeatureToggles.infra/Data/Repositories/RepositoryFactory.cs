using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace edk.ManagerFeatureToggles.Infra.Data.Repositories;

public class RepositoryFactory : IRepositoryFactory
{
    private readonly IServiceProvider _provider;

    public RepositoryFactory(IServiceProvider provider)
    {
        _provider = provider;
    }

    public virtual object Get<T>() where T : IGenericRepository
      => _provider.GetRequiredService(typeof(T));

    public virtual object Get(Type type)
       => _provider.GetRequiredService(type);
}
