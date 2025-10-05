using AuthService.Application.Features.Permissions.Requests.Commands;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Permissions.Handlers.Commands;

public class UpdatePermissionRequestHandler : IRequestHandler<UpdatePermissionRequest, Result<bool>>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdatePermissionRequestHandler(IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
    {
        _permissionRepository = permissionRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<bool>> Handle(UpdatePermissionRequest request, CancellationToken cancellationToken)
    {
        var permission = await _permissionRepository.GetByIdAsync(request.PermissionId, cancellationToken);

        if (permission == null)
        {
            return Error.None; //Добавить ошибку
        }
        
        var existingPermission = await _permissionRepository.GetByFilterAsync(
            p => p.PermissionName == request.PermissionDto.PermissionName,
            cancellationToken);

        if (existingPermission != null)
        {
            return Error.None; //Добавить ошибку
        }

        permission.UpdatePermission(request.PermissionDto.PermissionName);
        
        _permissionRepository.Update(permission);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}