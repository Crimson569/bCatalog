using AuthService.Application.Features.Roles.Requests.Commands;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Application.Primitives.Errors;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Roles.Handlers.Commands;

public class AddPermissionToRoleCommandHandler : IRequestHandler<AddPermissionToRoleCommand, Result<bool>>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IPermissionRepository _permissionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddPermissionToRoleCommandHandler(IRoleRepository roleRepository, IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
    {
        _roleRepository = roleRepository;
        _permissionRepository = permissionRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<bool>> Handle(AddPermissionToRoleCommand request, CancellationToken cancellationToken)
    {
        var permission = await _permissionRepository.GetByIdAsync(request.PermissionId, cancellationToken);

        if (permission == null)
        {
            return Error.None; //Добавить ошибку
        }

        var role = await _roleRepository.GetByIdAsync(request.RoleId, cancellationToken);

        if (role == null)
        {
            return ApplicationError.RoleWithIdNotFound(request.RoleId);
        }

        if (role.Permissions.Contains(permission))
        {
            return Error.None; //Добавить ошибку
        }

        role.AddPermission(permission);
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}