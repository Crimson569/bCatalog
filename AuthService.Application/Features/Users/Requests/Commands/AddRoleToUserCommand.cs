using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Requests.Commands;

public class AddRoleToUserCommand : IRequest<Result<bool>>
{
    public Guid UserId { get; set; }
    public UserAddRoleDto UserAddRoleDto { get; set; }
}