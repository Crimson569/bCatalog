using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Requests.Commands;

public class RemoveRoleFromUserCommand : IRequest<Result<bool>>
{
    public Guid UserId { get; set; }
    public UserRemoveRoleDto UserRemoveRoleDto { get; set; }
}