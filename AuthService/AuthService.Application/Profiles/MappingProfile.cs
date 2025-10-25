using AuthService.Application.Dto.PermissionDataTransferObjects;
using AuthService.Application.Dto.RoleDataTransferObjects;
using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Domain.Entities;
using AutoMapper;

namespace AuthService.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<Role, RoleDto>();
        CreateMap<Permission, PermissionDto>();
    }
}