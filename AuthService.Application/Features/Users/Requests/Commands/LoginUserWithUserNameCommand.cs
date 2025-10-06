using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Requests.Commands;

public class LoginUserWithUserNameCommand : IRequest<Result<string>>
{
    public UserLoginWithUserNameDto UserDto { get; set; }
}