using AuthService.Application.Dto.RoleDataTransferObjects;

namespace AuthService.Application.Dto.UserDataTransferObjects;

public record UserDto(Guid Id, string Username, string UserEmail, string UserAvatar, List<RoleDto> Roles);