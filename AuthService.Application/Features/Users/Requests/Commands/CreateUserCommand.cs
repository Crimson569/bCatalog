using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Requests.Commands;

public class CreateUserCommand : IRequest<Result<bool>>
{
    public UserCreateDto UserDto { get; set; }
}