using AuthService.Domain.Common;

namespace AuthService.Application.Primitives.Errors;

public static class ApplicationError
{
    public static Error UserWithUserNameNotFound(string userName) => new Error("User.NotFound", $"User with username {userName} not found.");
    public static Error UserWithEmailNotFound(string email) => new Error("User.NotFound", $"User with email {email} not found.");
    public static Error UserWithIdNotFound(Guid id) => new Error("User.NotFound", $"User with id {id} not found.");
    
    public static Error RoleWithRoleNameNotFound(string roleName) => new Error("Role.NotFound", $"Role with username {roleName} not found.");
    public static Error RoleWithIdNotFound(Guid id) => new Error("Role.NotFound", $"Role with id {id} not found.");

    public static Error WrongPassword() => new Error("User.WrongPassword", "Wrong password");
}