namespace edk.ManagerFeatureToggles.Infra.Data.EF.Configuration
{
    using edk.ManagerFeaturesToggles.Domain.Entities;
    using edk.ManagerFeaturesToggles.Domain.Entities.Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class EnvironmentBuildConfiguration : IEntityTypeConfiguration<EnvironmentBuild>
    {
        public void Configure(EntityTypeBuilder<EnvironmentBuild> builder)
        {

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(SizeFields.SMALL);

            builder.Property(e => e.Type)
                .HasConversion<string>()
                .IsRequired();

            builder.Property(e => e.Enable)
                .IsRequired();

            builder.HasMany(e => e.AccessSystems)
                  .WithOne(a => a.Environment)
                  .HasForeignKey(a => a.EnvironmentId);
        }
    }

}
