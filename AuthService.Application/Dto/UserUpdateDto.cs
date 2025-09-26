namespace AuthService.Application.Dto;

public record UserUpdateDto(string Username, string NewPassword, string OldPassword);