using AuthService.Application.Dto.PermissionDataTransferObjects;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Permissions.Requests.Queries;

public class GetPermissionsRequest : IRequest<Result<List<PermissionDto>>>
{
    
}