using AuthService.Application.Features.Users.Requests.Commands;
using AuthService.Application.Interfaces.Auth;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Application.Primitives.Errors;
using AuthService.Domain.Common;
using AuthService.Domain.Entities;
using MediatR;

namespace AuthService.Application.Features.Users.Handlers.Commands;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Result<bool>>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPasswordHasher _passwordHasher;

    public UpdateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork, IPasswordHasher passwordHasher)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _passwordHasher = passwordHasher;
    }

    public async Task<Result<bool>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserDto.UserId, cancellationToken);

        if (user == null)
        {
            return ApplicationError.UserWithIdNotFound(request.UserDto.UserId);
        }

        var oldHashedPasswordIsMatch = _passwordHasher.Verify(request.UserDto.OldPassword, user.PasswordHash);

        if (!oldHashedPasswordIsMatch)
        {
            return ApplicationError.UserWithIdNotFound(request.UserDto.UserId);
        }

        var newHashedPassword = _passwordHasher.GenerateHash(request.UserDto.NewPassword);

        user.UpdateUserName(request.UserDto.Username)
            .UpdateUserEmail(request.UserDto.UserEmail)
            .UpdatePassword(newHashedPassword);
        
        _userRepository.Update(user);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}