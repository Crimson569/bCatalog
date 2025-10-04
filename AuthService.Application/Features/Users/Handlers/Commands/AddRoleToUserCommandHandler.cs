using AuthService.Application.Features.Users.Requests.Commands;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Application.Primitives.Errors;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Handlers.Commands;

public class AddRoleToUserCommandHandler : IRequestHandler<AddRoleToUserCommand, Result<bool>>
{
    private readonly IUserRepository _userRepository;
    private readonly IRoleRepository _roleRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddRoleToUserCommandHandler(IUserRepository userRepository, IRoleRepository roleRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _roleRepository = roleRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<bool>> Handle(AddRoleToUserCommand request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetByIdAsync(request.UserAddRoleDto.RoleId, cancellationToken);

        if (role == null)
        {
            return ApplicationError.RoleWithIdNotFound(request.UserAddRoleDto.RoleId);
        }

        var user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);

        if (user == null)
        {
            return ApplicationError.UserWithIdNotFound(request.UserId);
        }

        if (user.Roles.Contains(role))
        {
            return Error.None; //Добавить ошибку
        }

        user.AddRole(role);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}