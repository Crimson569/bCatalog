namespace AuthService.Application.Dto.UserDataTransferObjects;

public record UserCreateDto(string Username, string UserEmail, string Password);