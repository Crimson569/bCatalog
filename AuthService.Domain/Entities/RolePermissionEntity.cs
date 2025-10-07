namespace AuthService.Domain.Entities;

public class RolePermissionEntity
{
    public Guid RoleId { get; set; }
    public Guid PermissionId { get; set; }
}