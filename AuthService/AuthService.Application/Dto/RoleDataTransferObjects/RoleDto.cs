using AuthService.Application.Dto.PermissionDataTransferObjects;

namespace AuthService.Application.Dto.RoleDataTransferObjects;

public record RoleDto(Guid Id, string RoleName, List<PermissionDto> Permissions);