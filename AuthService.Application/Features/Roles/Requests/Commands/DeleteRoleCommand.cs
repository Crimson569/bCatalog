using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Roles.Requests.Commands;

public class DeleteRoleCommand : IRequest<Result<bool>>
{
    public Guid RoleId { get; set; }
}