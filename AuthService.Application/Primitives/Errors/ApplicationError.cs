using AuthService.Domain.Common;
using AuthService.Domain.Entities;

namespace AuthService.Application.Primitives.Errors;

public static class ApplicationError
{
    public static Error UserWithUserNameNotFound(string userName) => new Error("User.NotFound", $"User with username {userName} not found.");
    public static Error UserWithEmailNotFound(string email) => new Error("User.NotFound", $"User with email {email} not found.");
    public static Error UserWithIdNotFound(Guid id) => new Error("User.NotFound", $"User with id {id} not found.");
    public static Error UserAlreadyHaveRole(Role role) =>
        new Error("User.AlreadyHaveRole", $"User already have role: {role.RoleName}");
    public static Error UserDoesNotHaveRole(Role role) =>
        new Error("User.DoesNotHaveRole", $"User doesn't have role: {role.RoleName}");
    
    
    public static Error RoleWithRoleNameNotFound(string roleName) => new Error("Role.NotFound", $"Role with username {roleName} not found.");
    public static Error RoleWithIdNotFound(Guid id) => new Error("Role.NotFound", $"Role with id {id} not found.");


    public static Error PermissionWithNameNotFound(string permissionName) =>
        new Error("Permission.NotFound", $"Permission with name: {permissionName} not found.");
    public static Error PermissionWithIdNotFound(Guid id) =>
        new Error("Permission.NotFound", $"Permission with id: {id} not found.");

    public static Error PermissionWithNameAlreadyExists(string permissionName) =>
        new Error("Permission.AlreadyExists", $"Permission with name: {permissionName} already exists.");
    public static Error PermissionWithIdAlreadyExists(Guid id) =>
        new Error("Permission.AlreadyExists", $"Permission with id: {id} already exists.");
    
    public static Error WrongPassword() => new Error("User.WrongPassword", "Wrong password");

    public static Error RoleDoesNotHavePermission(string roleName, string permissionName) =>
        new Error("Role.DoesNotHavePermission", $"Role {roleName} already have permission: {permissionName}");
    public static Error RoleAlreadyHavePermission(string roleName, string permissionName) =>
        new Error("Role.AlreadyHavePermission", $"Role {roleName} already have permission: {permissionName}");
    
}