using AuthService.Application.Features.Roles.Requests.Commands;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Roles.Handlers.Commands;

public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand, Result<bool>>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateRoleCommandHandler(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
    {
        _roleRepository = roleRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<bool>> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetByIdAsync(request.RoleId, cancellationToken);
        
        if (role == null)
        {
            return Error.None; //Добавить ошибку
        }

        role.UpdateRole(request.RoleDto.RoleName);
        
        _roleRepository.Update(role);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}