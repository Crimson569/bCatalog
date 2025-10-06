using AuthService.Application.Dto.RoleDataTransferObjects;

namespace AuthService.Application.Dto.UserDataTransferObjects;

public record UserDto(Guid Id, string Username, string UserEmail, List<RoleDto> Roles);