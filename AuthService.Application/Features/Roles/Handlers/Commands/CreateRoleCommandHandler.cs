using AuthService.Application.Features.Roles.Requests.Commands;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using AuthService.Domain.Entities;
using MediatR;

namespace AuthService.Application.Features.Roles.Handlers.Commands;

public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, Result<bool>>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateRoleCommandHandler(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
    {
        _roleRepository = roleRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<bool>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        var newRole = new Role(Guid.NewGuid(), request.RoleDto.RoleName);
        await _roleRepository.CreateAsync(newRole, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return true;
    }
}