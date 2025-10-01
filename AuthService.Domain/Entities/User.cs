namespace AuthService.Domain.Entities;

public class User : BaseEntity
{
    private string _userName;
    private string _userEmail;
    private string _passwordHash;
    private List<Role> _roles;
    
    public User(Guid id, string userName, string userEmail, string passwordHash) : base(id)
    {
        UserName = userName;
        UserEmail = userEmail;
        PasswordHash = passwordHash;
    }

    public string UserName
    {
        get => _userName;
        private set { _userName = value; }
    }

    public string UserEmail
    {
        get => _userEmail;
        set
        {
            _userEmail = value;
        }
    }

    public string PasswordHash
    {
        get => _passwordHash;
        private set
        {
            _passwordHash = value; 
        }
    }
    public IReadOnlyCollection<Role> Roles => _roles;

    public User UpdateUserName(string newUserName)
    {
        UserName = newUserName;
        return this;
    }

    public User UpdateUserEmail(string newUserEmail)
    {
        UserEmail = newUserEmail;
        return this;
    }

    public User UpdatePassword(string newPasswordHash)
    {
        PasswordHash = newPasswordHash;
        return this;
    }
}