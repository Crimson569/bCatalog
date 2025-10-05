using AuthService.Application.Dto;
using AuthService.Application.Features.Permissions.Requests.Queries;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using AutoMapper;
using MediatR;

namespace AuthService.Application.Features.Permissions.Handlers.Queries;

public class GetPermissionsRequestHandler : IRequestHandler<GetPermissionsRequest, Result<List<PermissionDto>>>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IMapper _mapper;

    public GetPermissionsRequestHandler(IPermissionRepository permissionRepository, IMapper mapper)
    {
        _permissionRepository = permissionRepository;
        _mapper = mapper;
    }

    public async Task<Result<List<PermissionDto>>> Handle(GetPermissionsRequest request, CancellationToken cancellationToken)
    {
        var permissions = await _permissionRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<PermissionDto>>(permissions);
    }
}