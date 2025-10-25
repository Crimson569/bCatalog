using AuthService.Application.Features.Users.Requests.Commands;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Application.Primitives.Errors;
using AuthService.Domain.Common;
using MediatR;

namespace AuthService.Application.Features.Users.Handlers.Commands;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Result<bool>>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<bool>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);

        if (user == null)
        {
            return ApplicationError.UserWithIdNotFound(request.UserId);
        }
        
        _userRepository.Remove(user);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}