namespace edk.ManagerFeatureToggles.Infra.Data.EF.Configuration
{
    using edk.ManagerFeaturesToggles.Domain.Entities;
    using edk.ManagerFeaturesToggles.Domain.Entities.Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SystemAppConfiguration : IEntityTypeConfiguration<SystemApp>
    {
        public void Configure(EntityTypeBuilder<SystemApp> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(SizeFields.LARGE);

            builder.HasOne(s => s.Customer)
                .WithMany(c => c.Systems)
                .HasForeignKey(s => s.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.FeatureToggles)
                .WithOne(ft => ft.System)
                .HasForeignKey(ft => ft.SystemId)
                .OnDelete(DeleteBehavior.NoAction);
        }


    }



}
