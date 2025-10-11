using AuthService.Application.Features.Permissions.Requests.Commands;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Application.Primitives.Errors;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Permissions.Handlers.Commands;

public class DeletePermissionRequestHandler : IRequestHandler<DeletePermissionRequest, Result<bool>>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeletePermissionRequestHandler(IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
    {
        _permissionRepository = permissionRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<bool>> Handle(DeletePermissionRequest request, CancellationToken cancellationToken)
    {
        var permission = await _permissionRepository.GetByIdAsync(request.PermissionId, cancellationToken);

        if (permission == null)
        {
            return ApplicationError.PermissionWithIdNotFound(request.PermissionId);
        }
        
        _permissionRepository.Remove(permission);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}