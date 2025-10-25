using AuthService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthService.Persistence.Configurations.EntityFrameworkCore;

public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermissionEntity>
{
    private readonly AuthorizationOptions _authorizationOptions;

    public RolePermissionConfiguration(AuthorizationOptions authorization)
    {
        _authorizationOptions = authorization;
    }

    public void Configure(EntityTypeBuilder<RolePermissionEntity> builder)
    {
        builder.HasKey(r => new { r.RoleId, r.PermissionId });
    }
}