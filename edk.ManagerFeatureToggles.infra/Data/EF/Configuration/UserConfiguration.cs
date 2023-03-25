namespace edk.ManagerFeatureToggles.Infra.Data.EF.Configuration
{
    using edk.ManagerFeaturesToggles.Domain.Entities;
    using edk.ManagerFeaturesToggles.Domain.Entities.Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .HasMaxLength(SizeFields.NORMAL)
                .IsRequired();

            builder.Property(u => u.UserTenantId)
               .HasMaxLength(SizeFields.LARGE)
               .IsRequired();

            builder.HasOne(u => u.Tenant)
                .WithMany(t => t.Users)
                .HasForeignKey(u => u.TenantId);

            builder.HasOne<UserGroup>()
               .WithMany()
               .HasForeignKey(u => u.UserGroupId)
               .IsRequired();

            builder.HasIndex(u => new { u.UserTenantId, u.TenantId }).IsUnique();
        }
    }



}
