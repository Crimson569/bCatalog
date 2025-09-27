using AuthService.Application.Dto;
using AuthService.Application.Features.Roles.Requests.Queries;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using AutoMapper;
using MediatR;

namespace AuthService.Application.Features.Roles.Handlers.Queries;

public class GetRolesRequestHandler : IRequestHandler<GetRolesRequest, Result<List<RoleDto>>>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;

    public GetRolesRequestHandler(IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }

    public async Task<Result<List<RoleDto>>> Handle(GetRolesRequest request, CancellationToken cancellationToken)
    {
        var roles = await _roleRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<RoleDto>>(roles);
    }
}