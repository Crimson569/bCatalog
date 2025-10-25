using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Requests.Queries;

public class GetUsersRequest : IRequest<Result<List<UserDto>>>
{
    
}