using AuthService.Application.Features.Users.Requests.Commands;
using AuthService.Application.Interfaces.Auth;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Handlers.Commands;

public class LoginUserWithUserNameCommandHandler : IRequestHandler<LoginUserWithUserNameCommand, Result<string>>
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IJwtProvider _jwtProvider;
    
    public LoginUserWithUserNameCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher, IJwtProvider jwtProvider)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
        _jwtProvider = jwtProvider;
    }
    
    public async Task<Result<string>> Handle(LoginUserWithUserNameCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByFilterAsync(u => u.UserName == request.UserDto.Username, cancellationToken);

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