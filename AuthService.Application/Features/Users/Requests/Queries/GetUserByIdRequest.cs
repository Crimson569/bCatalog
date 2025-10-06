using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Requests.Queries;

public class GetUserByIdRequest : IRequest<Result<UserDto>>
{
    public Guid UserId { get; set; }
}