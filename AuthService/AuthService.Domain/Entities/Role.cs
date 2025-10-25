namespace AuthService.Domain.Entities;

public class Role : BaseEntity
{
    private string _roleName;
    private List<User> _users = new List<User>();
    private List<Permission> _permissions = new List<Permission>();
    

    public Role(Guid id, string roleName) : base(id)
    {
        _roleName = roleName;
    }
    
    private Role (Guid id) : base(id) { }

    public string RoleName
    {
        get => _roleName;
        set
        {
            _roleName = value;
        }
    }

    public IReadOnlyCollection<User> Users => _users;
    public IReadOnlyCollection<Permission> Permissions => _permissions;
    
    public Role UpdateRole(string roleName)
    {
        RoleName = roleName;
        return this;
    }

    public Role AddPermission(Permission permission)
    {
        _permissions.Add(permission);
        return this;
    }

    public Role RemovePermissionIfBelongs(Permission permission)
    {
        _permissions.Remove(permission);
        return this;
    }
}