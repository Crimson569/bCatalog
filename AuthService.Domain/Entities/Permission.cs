namespace AuthService.Domain.Entities;

public class Permission : BaseEntity
{
    private string _permissionName;
    private List<Role> _roles = new List<Role>();
    
    public Permission(Guid id, string permissionName) : base(id)
    {
        PermissionName = permissionName;
    }

    public string PermissionName
    {
        get => _permissionName;
        set
        {
            _permissionName = value;
        }
    }

    public IReadOnlyCollection<Role> Roles => _roles;

    public Permission UpdatePermission(string permissionName)
    {
        PermissionName = permissionName;
        return this;
    }
}