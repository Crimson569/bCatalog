using AuthService.Application.Dto;
using AuthService.Domain.Entities;
using AutoMapper;

namespace AuthService.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
    }
}