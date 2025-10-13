using AuthService.Application.Features.Users.Requests.Commands;
using AuthService.Application.Interfaces.Auth;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using AuthService.Domain.Entities;
using MediatR;

namespace AuthService.Application.Features.Users.Handlers.Commands;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Result<Guid>>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPasswordHasher _passwordHasher;

    public CreateUserCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _passwordHasher = passwordHasher;
    }

    public async Task<Result<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        //Провалидировать email на уникальность 
        
        var hashedPassword = _passwordHasher.GenerateHash(request.UserDto.Password);

        var newUser = new User(
            id: Guid.NewGuid(),
            userName: request.UserDto.Username,
            userEmail: request.UserDto.UserEmail,
            passwordHash: hashedPassword);

        await _userRepository.CreateAsync(newUser, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return newUser.Id; 
    }
}