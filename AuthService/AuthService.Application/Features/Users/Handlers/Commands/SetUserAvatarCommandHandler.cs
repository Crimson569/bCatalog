using AuthService.Application.Features.Users.Requests.Commands;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Application.Primitives.Errors;
using AuthService.Domain.Common;
using MediatR;
using Shared.Interfaces;

namespace AuthService.Application.Features.Users.Handlers.Commands;

public class SetUserAvatarCommandHandler : IRequestHandler<SetUserAvatarCommand, Result<bool>>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public SetUserAvatarCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork, IFileService fileService)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _fileService = fileService;
    }

    public async Task<Result<bool>> Handle(SetUserAvatarCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);

        if (user == null)
        {
            return ApplicationError.UserWithIdNotFound(request.UserId);
        }

        var avatarPath = await _fileService.SaveFileAsync(request.UserSetAvatarDto.Avatar);

        user.SetAvatar(avatarPath);
        
        _userRepository.Update(user);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}