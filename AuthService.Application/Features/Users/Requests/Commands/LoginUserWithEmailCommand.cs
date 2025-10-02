using AuthService.Application.Dto;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Requests.Commands;

public class LoginUserWithEmailCommand : IRequest<Result<string>>
{
    public UserLoginWithEmailDto UserDto { get; set; }
}