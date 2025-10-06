using AuthService.Application.Dto.RoleDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Roles.Requests.Commands;

public class CreateRoleCommand : IRequest<Result<bool>>
{
    public RoleCreateUpdateDto RoleDto { get; set; }
}