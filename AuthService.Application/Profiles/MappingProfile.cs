using AuthService.Application.Dto;
using AuthService.Domain.Entities;
using AutoMapper;

namespace AuthService.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>().ForMember(d => d.Roles, opt =>
        {
            opt.MapFrom(u => u.Roles.Select(r => new RoleDto(r.Id, r.RoleName)));
        });
        CreateMap<Role, RoleDto>();
        CreateMap<Permission, PermissionDto>();
    }
}