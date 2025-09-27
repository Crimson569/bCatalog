using AuthService.Application.Dto;
using AuthService.Application.Features.Users.Requests.Queries;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Common;
using AutoMapper;
using MediatR;

namespace AuthService.Application.Features.Users.Handlers.Queries;

public class GetUserByIdRequestHandler : IRequestHandler<GetUserByIdRequest, Result<UserDto>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetUserByIdRequestHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<Result<UserDto>> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);
        return _mapper.Map<UserDto>(user);
    }
}