namespace edk.ManagerFeatureToggles.Infra.Data.EF.Configuration
{
    using edk.ManagerFeaturesToggles.Domain.Entities;
    using edk.ManagerFeaturesToggles.Domain.Entities.Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AccessSystemConfiguration : IEntityTypeConfiguration<AccessSystem>
    {
        public void Configure(EntityTypeBuilder<AccessSystem> builder)
        {
            builder.HasKey(asys => asys.Id);

            builder.HasOne<Tenant>()
                .WithMany(ts => ts.AccessSystems)
                .HasForeignKey(asys => asys.TenantId)
                .IsRequired();

            builder.HasOne<EnvironmentBuild>()
                .WithMany(eb => eb.AccessSystems)
                .HasForeignKey(asys => asys.EnvironmentId)
                .IsRequired();

            builder.HasOne<SystemApp>()
                .WithMany(sa => sa.AccessSystems)
                .HasForeignKey(asys => asys.SystemId)
                .IsRequired();

            builder.Property(asys => asys.AccessToken)
                .IsRequired()
                .HasMaxLength(SizeFields.NORMAL);

            builder.Property(asys => asys.ExpirationDate);



        }
    }

}
