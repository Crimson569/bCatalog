using AuthService.Application.Features.Users.Requests.Commands;
using AuthService.Application.Interfaces.Auth;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Handlers.Commands;

public class LoginUserWithEmailCommandHandler : IRequestHandler<LoginUserWithEmailCommand, Result<string>>
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IJwtProvider _jwtProvider;

    public LoginUserWithEmailCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher, IJwtProvider jwtProvider)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
        _jwtProvider = jwtProvider;
    }

    public async Task<Result<string>> Handle(LoginUserWithEmailCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByFilterAsync(u => u.UserEmail == request.UserDto.Email, cancellationToken);

        if (user == null)
        {
            return Error.None; //Добавить ошибку
        }

        var passwordMatch = _passwordHasher.Verify(request.UserDto.Password, user.PasswordHash);

        if (!passwordMatch)
        {
            return Error.None; //Добавить ошибку
        }

        var token = _jwtProvider.GenerateToken(user);

        return token;
    }
}