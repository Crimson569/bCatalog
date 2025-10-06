namespace AuthService.Application.Dto;

public record RoleDto(Guid Id, string RoleName, List<PermissionDto> Permissions);