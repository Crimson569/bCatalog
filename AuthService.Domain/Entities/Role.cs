namespace AuthService.Domain.Entities;

public class Role : BaseEntity
{
    private string _roleName;
    private List<User> _users;

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

    public IReadOnlyCollection<User> Users => _users;
    
    public Role UpdateRole(string roleName)
    {
        RoleName = roleName;
        return this;
    }
}