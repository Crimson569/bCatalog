using AuthService.Application.Dto.PermissionDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Permissions.Requests.Commands;

public class CreatePermissionRequest : IRequest<Result<bool>>
{
    public PermissionCreateUpdateDto PermissionDto { get; set; }
}