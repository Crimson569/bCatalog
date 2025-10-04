using AuthService.Domain.Entities;

namespace AuthService.Application.Dto;

public record UserDto(Guid Id, string Username, string UserEmail, List<RoleDto> Roles);