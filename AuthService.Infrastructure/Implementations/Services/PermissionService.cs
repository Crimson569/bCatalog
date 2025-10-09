using AuthService.Application.Interfaces.Repositories;
using AuthService.Application.Interfaces.Services;
using AuthService.Domain.Enums;

namespace AuthService.Infrastructure.Implementations.Services;

public class PermissionService : IPermissionService
{
    private readonly IUserRepository _userRepository;

    public PermissionService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<HashSet<PermissionEnum>> GetPermissionsAsync(Guid userId, CancellationToken cancellationToken)
    {
        return await _userRepository.GetUserPermissionsAsync(userId, cancellationToken);
    }
}