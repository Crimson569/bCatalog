using AuthService.Domain.Entities;

namespace AuthService.Application.Dto;

public record UserDto(string Username, string UserEmail, IReadOnlyCollection<Role> Roles);