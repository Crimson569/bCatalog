using AuthService.Application.Dto.PermissionDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Permissions.Requests.Queries;

public class GetPermissionByIdRequest : IRequest<Result<PermissionDto>>
{
    public Guid PermissionId { get; set; }
}