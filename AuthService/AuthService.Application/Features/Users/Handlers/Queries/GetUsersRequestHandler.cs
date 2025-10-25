using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Application.Features.Users.Requests.Queries;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using AutoMapper;
using MediatR;

namespace AuthService.Application.Features.Users.Handlers.Queries;

public class GetUsersRequestHandler : IRequestHandler<GetUsersRequest, Result<List<UserDto>>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetUsersRequestHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<Result<List<UserDto>>> Handle(GetUsersRequest request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<UserDto>>(users);
    }
}