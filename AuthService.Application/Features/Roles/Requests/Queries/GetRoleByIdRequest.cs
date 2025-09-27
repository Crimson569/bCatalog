using AuthService.Application.Dto;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Roles.Requests.Queries;

public class GetRoleByIdRequest : IRequest<Result<RoleDto>>
{
    public Guid RoleId { get; set; }
}