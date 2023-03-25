namespace edk.ManagerFeatureToggles.Infra.Data.EF.Configuration
{
    using edk.ManagerFeaturesToggles.Domain.Entities;
    using edk.ManagerFeaturesToggles.Domain.Entities.Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TenantConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(SizeFields.LARGE);

            builder.Property(t => t.Enable)
            .IsRequired();

            builder.HasOne(t => t.Customer)
                .WithMany(c => c.Tenants)
                .HasForeignKey(t => t.CustomerId)
                .IsRequired();

        }
    }

}
