using edk.ManagerFeaturesToggles.Domain.Entities;
using edk.ManagerFeatureToggles.Infra.Data.EF.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace edk.ManagerFeatureToggles.Infra.Data;

public class FeatureToggleDbContext : DbContext
{
    public FeatureToggleDbContext(DbContextOptions<FeatureToggleDbContext> options)
        : base(options) {
    
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<SystemApp> Systems { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<EnvironmentBuild> Enviroments { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserGroup> UserGroups { get; set; }
    public DbSet<FeatureToggle> FeatureToggles { get; set; }
    public DbSet<ValueSelect> ValueSelect { get; set; }
    public DbSet<ValueOption> ValueOptions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new EnvironmentBuildConfiguration());
        modelBuilder.ApplyConfiguration(new FeatureToggleConfiguration());
        modelBuilder.ApplyConfiguration(new SystemAppConfiguration());
        modelBuilder.ApplyConfiguration(new TenantConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserGroupConfiguration());
        modelBuilder.ApplyConfiguration(new ValueSelectConfiguration());
        modelBuilder.ApplyConfiguration(new ValueOptionConfiguration());
        modelBuilder.ApplyConfiguration(new AccessSystemConfiguration());

        
    }
}
