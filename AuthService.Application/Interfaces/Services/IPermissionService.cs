using AuthService.Domain.Enums;

namespace AuthService.Application.Interfaces.Services;

public interface IPermissionService
{
    Task<HashSet<PermissionEnum>> GetPermissionsAsync(Guid userId, CancellationToken cancellationToken = default);
}