using AuthService.Domain.Entities;
using AuthService.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthService.Persistence.Configurations.EntityFrameworkCore;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("roles");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.RoleName).IsRequired();
        builder.HasIndex(r => r.RoleName).IsUnique();
        
        builder.Property(r => r.CreatedAt).IsRequired();
        builder.Property(r => r.UpdatedAt).IsRequired();

        var roles = Enum
            .GetValues<RoleEnum>()
            .Select(r => new Role
                (
                    Guid.NewGuid(), 
                    r.ToString()
                ));

        builder.HasData(roles);

        builder
            .HasMany(r => r.Permissions)
            .WithMany(p => p.Roles)
            .UsingEntity<RolePermissions>();
    }
}