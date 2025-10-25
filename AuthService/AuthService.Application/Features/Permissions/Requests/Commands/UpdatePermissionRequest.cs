using AuthService.Application.Dto.PermissionDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Permissions.Requests.Commands;

public class UpdatePermissionRequest : IRequest<Result<bool>>
{
    public Guid PermissionId { get; set; }
    public PermissionCreateUpdateDto PermissionDto { get; set; }
}