namespace AuthService.Domain.Entities;

public class Role : BaseEntity
{
    private string _roleName;

    public Role(Guid id, string roleName) : base(id)
    {
        _roleName = roleName;
    }

    public string RoleName
    {
        get => _roleName;
        set
        {
            _roleName = value;
        }
    }

    public Role UpdateRole(string roleName)
    {
        RoleName = roleName;
        return this;
    }
}