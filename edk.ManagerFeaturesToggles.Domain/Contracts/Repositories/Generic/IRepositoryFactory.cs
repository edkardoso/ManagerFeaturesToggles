using System;

namespace edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;

public interface IRepositoryFactory
{
    object Get(Type type);
    object Get<T>() where T : IGenericRepository;
}