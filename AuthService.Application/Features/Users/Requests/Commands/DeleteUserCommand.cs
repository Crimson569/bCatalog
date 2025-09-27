using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Requests.Commands;

public class DeleteUserCommand : IRequest<Result<bool>>
{
    public Guid UserId { get; set; }
}