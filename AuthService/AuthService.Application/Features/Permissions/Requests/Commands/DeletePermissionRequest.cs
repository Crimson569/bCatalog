using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Permissions.Requests.Commands;

public class DeletePermissionRequest : IRequest<Result<bool>>
{
    public Guid PermissionId { get; set; }
}