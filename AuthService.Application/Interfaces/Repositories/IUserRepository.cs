using AuthService.Domain.Entities;
using AuthService.Domain.Enums;

namespace AuthService.Application.Interfaces.Repositories;

public interface IUserRepository : IGenericRepository<User>
{
    Task<HashSet<PermissionEnum>> GetUserPermissionsAsync(Guid userId, CancellationToken cancellationToken = default);
}