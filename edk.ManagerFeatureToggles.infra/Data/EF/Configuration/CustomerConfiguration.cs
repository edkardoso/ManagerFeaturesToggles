namespace edk.ManagerFeatureToggles.Infra.Data.EF.Configuration
{
    using edk.ManagerFeaturesToggles.Domain.Entities;
    using edk.ManagerFeaturesToggles.Domain.Entities.Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(SizeFields.LARGE);

            builder.Property(c => c.Owner)
                .IsRequired()
                .HasMaxLength(SizeFields.LARGE);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(SizeFields.EXTRA_LARGE);

            builder.Property(c => c.Login)
                .IsRequired()
                .HasMaxLength(SizeFields.NORMAL);

            builder.Property(c => c.Password)
                .IsRequired()
                .HasMaxLength(SizeFields.EXTRA_LARGE);

            builder.HasMany(c => c.Systems)
                   .WithOne(s => s.Customer)
                   .HasForeignKey(s => s.CustomerId);

            builder.HasMany(c => c.Tenants)
                   .WithOne(s => s.Customer)
                   .HasForeignKey(s => s.CustomerId);
        }
    }

}
