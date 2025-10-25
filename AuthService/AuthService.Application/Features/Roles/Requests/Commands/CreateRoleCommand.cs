using AuthService.Application.Dto.RoleDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Roles.Requests.Commands;

public class CreateRoleCommand : IRequest<Result<Guid>>
{
    public RoleCreateUpdateDto RoleDto { get; set; }
}