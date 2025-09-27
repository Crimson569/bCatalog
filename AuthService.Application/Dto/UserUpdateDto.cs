namespace AuthService.Application.Dto;

public record UserUpdateDto(Guid UserId, string Username, string NewPassword, string OldPassword);