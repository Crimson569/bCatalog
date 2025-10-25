using AuthService.Domain.Entities;
using AuthService.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthService.Persistence.Configurations.EntityFrameworkCore;

public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.ToTable("permissions");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.PermissionName).IsRequired();
        builder.HasIndex(p => p.PermissionName).IsUnique();

        var permissions = Enum
            .GetValues<PermissionEnum>()
            .Select(p =>
                new Permission
                    (
                        Guid.NewGuid(), 
                        p.ToString()
                    ));

        builder.HasData(permissions);
    }
}