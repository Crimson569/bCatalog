using AuthService.Application.Dto.RoleDataTransferObjects;
using AuthService.Application.Features.Roles.Requests.Queries;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Application.Primitives.Errors;
using AuthService.Domain.Common;
using AutoMapper;
using MediatR;

namespace AuthService.Application.Features.Roles.Handlers.Queries;

public class GetRoleByIdRequestHandler : IRequestHandler<GetRoleByIdRequest, Result<RoleDto>>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;

    public GetRoleByIdRequestHandler(IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }

    public async Task<Result<RoleDto>> Handle(GetRoleByIdRequest request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetByIdAsync(request.RoleId, cancellationToken);

        if (role == null)
        {
            return ApplicationError.RoleWithIdNotFound(request.RoleId);
        }
        
        return _mapper.Map<RoleDto>(role);
    }
}