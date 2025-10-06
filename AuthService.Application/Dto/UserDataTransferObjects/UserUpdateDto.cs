namespace AuthService.Application.Dto.UserDataTransferObjects;

public record UserUpdateDto(Guid UserId, string Username, string UserEmail, string NewPassword, string OldPassword);