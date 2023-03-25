namespace edk.ManagerFeatureToggles.Infra.Data.EF.Configuration
{
    using edk.ManagerFeaturesToggles.Domain.Entities;
    using edk.ManagerFeaturesToggles.Domain.Entities.Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ValueOptionConfiguration : IEntityTypeConfiguration<ValueOption>
    {
        public void Configure(EntityTypeBuilder<ValueOption> builder)
        {

            builder.HasKey(vo => vo.Id);

            builder.Property(vo => vo.Value)
                .HasMaxLength(SizeFields.NORMAL)
                .IsRequired();

            builder.HasOne(vo => vo.FeatureToggle)
                .WithMany(ft => ft.Values)
                .HasForeignKey(vo => vo.FeatureToggleId)
                .IsRequired();

        }
    }

}
