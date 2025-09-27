using AuthService.Application.Dto;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Requests.Commands;

public class UpdateUserCommand : IRequest<Result<bool>>
{
    public UserUpdateDto UserDto { get; set; }
}