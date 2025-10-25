using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Roles.Requests.Commands;

public class RemovePermissionFromRoleCommand : IRequest<Result<bool>>
{
    public Guid RoleId { get; set; }
    public Guid PermissionId { get; set; }
}