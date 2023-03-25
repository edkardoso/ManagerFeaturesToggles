using edk.ManagerFeaturesToggles.Domain.Contracts.Common;
using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;
using edk.Tools;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace edk.ManagerFeatureToggles.Infra.Data.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
{
    private readonly FeatureToggleDbContext _dbContext;

    protected DbSet<T> DbSet { get; private set; }
    protected IQueryable<T> Query { get; private set; }

    protected GenericRepository(FeatureToggleDbContext dbContext)
    {
        _dbContext = dbContext;
        DbSet = dbContext.Set<T>();
        Query = DbSet.Where(e => !e.Deleted);
    }
    public async Task AddAsync(T entity)
        => _ = await DbSet.AddAsync(entity).ConfigureAwait(false);

    public async Task AddRangeAsync(IReadOnlyCollection<T> entities)
        => await DbSet.AddRangeAsync(entities).ConfigureAwait(false);

    public async Task DeleteAsync(T entity)
    {
        DbSet.Remove(entity);
        await Task.CompletedTask.ConfigureAwait(false);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var entityOption = await GetByIdAsync(id);

        entityOption.IsNull.Not().WhenTrue(async () =>
        {
            await DeleteAsync(entityOption.Match(e => e, () => null));
        });

    }

    public async Task<Option<T>> FirstOrDefaultAsync()
       => new Option<T>(await Query.FirstOrDefaultAsync().ConfigureAwait(false));

    public async Task<Option<T>> FirstOrDefaultAsync(Expression<Func<T, bool>> filter)
       => new Option<T>(await Query.FirstOrDefaultAsync(filter).ConfigureAwait(false));

    public async Task<Option<T>> GetByIdAsync(Guid id)
       => new Option<T>(await Query.FirstOrDefaultAsync(e => e.Id.Equals(id)));

    public Task<Option<List<T>>> SearchAsync(Expression<Func<T, bool>> filter)
       => Task.Run(() => new Option<List<T>>(Query.Where(filter).ToList()));

    public async Task UpdateAsync(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await Task.CompletedTask.ConfigureAwait(false);
    }

    public async Task<Option<T>> SingleAsync(Expression<Func<T, bool>> filter)
    {
        if (Query.Count() == 0)
        {
            return default;
        }

        var result = await Query.SingleAsync(filter);
        return new Option<T>(result);
    }
}
