using AuthService.Application.Interfaces.Auth;

namespace AuthService.Infrastructure.Implementations.Auth;

public class PasswordHasher : IPasswordHasher
{
    public string GenerateHash(string password)
    {
        return BCrypt.Net.BCrypt.EnhancedHashPassword(password);
    }

    public bool Verify(string password, string hashedPassword)
    {
        return BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword);
    }
}