using AuthService.Application.Dto.RoleDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Roles.Requests.Commands;

public class UpdateRoleCommand : IRequest<Result<bool>>
{
    public Guid RoleId { get; set; }
    public RoleCreateUpdateDto RoleDto { get; set; }
}