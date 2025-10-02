using AuthService.Application.Dto;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Requests.Commands;

public class LoginUserWithUsernameCommand : IRequest<Result<string>>
{
    private UserLoginWithUsernameDto UserDto { get; set; }
}