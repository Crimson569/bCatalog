using AuthService.Application.Features.Permissions.Requests.Commands;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Application.Primitives.Errors;
using AuthService.Domain.Common;
using AuthService.Domain.Entities;
using MediatR;

namespace AuthService.Application.Features.Permissions.Handlers.Commands;

public class CreatePermissionRequestHandler : IRequestHandler<CreatePermissionRequest, Result<Guid>>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreatePermissionRequestHandler(IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
    {
        _permissionRepository = permissionRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<Guid>> Handle(CreatePermissionRequest request, CancellationToken cancellationToken)
    {
        var existingPermission = await _permissionRepository.GetByFilterAsync(
            p => p.PermissionName == request.PermissionDto.PermissionName,
            cancellationToken);

        if (existingPermission != null)
        {
            return ApplicationError.PermissionWithNameAlreadyExists(request.PermissionDto.PermissionName);
        }

        var newPermission = new Permission(Guid.NewGuid(), request.PermissionDto.PermissionName);

        await _permissionRepository.CreateAsync(newPermission, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return newPermission.Id;
    }
}