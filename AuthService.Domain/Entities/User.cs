namespace AuthService.Domain.Entities;

public class User : BaseEntity
{
    private string _userName;
    private string _userEmail;
    private string _passwordHash;
    private string _passwordSalt;
    private List<Role> _roles;
    
    public User(Guid id, string userName, string passwordHash, string passwordSalt) : base(id)
    {
        UserName = userName;
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
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
    public string PasswordSalt
    {
        get => _passwordSalt;
        private set
        {
            _passwordSalt = value;
        }
    }

    public IReadOnlyCollection<Role> Roles => _roles;
}