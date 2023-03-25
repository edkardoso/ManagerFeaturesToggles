namespace edk.ManagerFeatureToggles.Infra.Data.EF.Configuration
{
    using edk.ManagerFeaturesToggles.Domain.Entities;
    using edk.ManagerFeaturesToggles.Domain.Entities.Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class FeatureToggleConfiguration : IEntityTypeConfiguration<FeatureToggle>
    {
        public void Configure(EntityTypeBuilder<FeatureToggle> builder)
        {

            builder.HasKey(ft => ft.Id);

            builder.Property(ft => ft.Name)
                .HasMaxLength(SizeFields.NORMAL)
                .IsRequired();

            builder.Property(ft => ft.Description)
                .HasMaxLength(SizeFields.EXTRA_LARGE);

            builder.Property(ft => ft.DataType)
                    .HasConversion<string>();

            builder.HasOne(ft => ft.System)
                .WithMany(s => s.FeatureToggles)
                .HasForeignKey(ft => ft.SystemId)
                .IsRequired();


            builder.HasMany(ft => ft.Values)
                .WithOne(vo => vo.FeatureToggle)
                .HasForeignKey(vo => vo.FeatureToggleId);


            builder.HasMany(ft => ft.ValuesSelects)
                .WithOne(vs => vs.FeatureToggle)
                .HasForeignKey(vs => vs.FeatureToggleId);

            builder.HasOne(ft => ft.Tenant)
                .WithMany(t => t.FeatureToggles)
                .HasForeignKey(ft => ft.TenantId);



        }
    }



}
