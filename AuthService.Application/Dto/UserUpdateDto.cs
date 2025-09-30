namespace AuthService.Application.Dto;

public record UserUpdateDto(Guid UserId, string Username, string UserEmail, string NewPassword, string OldPassword);