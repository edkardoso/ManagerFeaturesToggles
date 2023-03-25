namespace edk.ManagerFeatureToggles.Infra.Data.EF.Configuration
{
    using edk.ManagerFeaturesToggles.Domain.Entities;
    using edk.ManagerFeaturesToggles.Domain.Entities.Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
    {
        public void Configure(EntityTypeBuilder<UserGroup> builder)
        {

            builder.HasKey(ug => ug.Id);

            builder.Property(ug => ug.Name)
                .HasMaxLength(SizeFields.NORMAL)
                .IsRequired();


            builder.Property(ug => ug.UserTenantId)
                .IsRequired();

            builder.HasMany<User>()
                .WithOne(u => u.UserGroup)
                .HasForeignKey(u => u.UserGroupId)
                .IsRequired();

        }
    }



}
