using Microsoft.AspNetCore.Http;

namespace AuthService.Application.Dto.UserDataTransferObjects;

public record UserSetAvatarDto(IFormFile Avatar);