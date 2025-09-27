using AuthService.Application.Features.Roles.Requests.Commands;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Roles.Handlers.Commands;

public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, Result<bool>>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteRoleCommandHandler(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
    {
        _roleRepository = roleRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<bool>> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetByIdAsync(request.RoleId, cancellationToken);

        if (role == null)
        {
            return Error.None; //Добавить ошибку
        }
        
        _roleRepository.Remove(role);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}