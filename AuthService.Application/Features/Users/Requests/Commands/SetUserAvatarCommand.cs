using AuthService.Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace AuthService.Application.Features.Users.Requests.Commands;

public class SetUserAvatarCommand : IRequest<Result<bool>>
{
    public Guid UserId { get; set; }
    public IFormFile Avatar { get; set; }
}