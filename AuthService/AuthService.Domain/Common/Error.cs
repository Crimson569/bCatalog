namespace AuthService.Domain.Common;

public record Error(string Code, string Description)
{
    public static Error None => new(string.Empty, String.Empty);
}