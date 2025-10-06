using AuthService.Application.Dto.PermissionDataTransferObjects;
using AuthService.Application.Features.Permissions.Requests.Queries;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using AutoMapper;
using MediatR;

namespace AuthService.Application.Features.Permissions.Handlers.Queries;

public class GetPermissionByIdRequestHandler : IRequestHandler<GetPermissionByIdRequest, Result<PermissionDto>>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IMapper _mapper;

    public GetPermissionByIdRequestHandler(IPermissionRepository permissionRepository, IMapper mapper)
    {
        _permissionRepository = permissionRepository;
        _mapper = mapper;
    }

    public async Task<Result<PermissionDto>> Handle(GetPermissionByIdRequest request, CancellationToken cancellationToken)
    {
        var permission = await _permissionRepository.GetByIdAsync(request.PermissionId, cancellationToken);

        if (permission == null)
        {
            return Error.None; //Добавить ошибку
        }

        return _mapper.Map<PermissionDto>(permission);
    }
}