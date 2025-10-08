using AuthService.Domain.Enums;
using Microsoft.AspNetCore.Authorization;

namespace AuthService.Infrastructure.Implementations.Auth;

public class PermissionRequirement(PermissionEnum[] permissions) : IAuthorizationRequirement
{
    private PermissionEnum[] Permissions { get; set; } = permissions;
}