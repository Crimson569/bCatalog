using AuthService.Application.Dto.UserDataTransferObjects;
using FluentValidation;

namespace AuthService.Api.Validators.Users;

public class UserUpdateDtoValidator : AbstractValidator<UserUpdateDto>
{
    public UserUpdateDtoValidator()
    {
        RuleFor(u => u.Username)
            .MaximumLength(50)
            .MinimumLength(3);
        
        RuleFor(u => u.UserEmail);
        
        RuleFor(u => u.OldPassword)
            .MaximumLength(20)
            .MinimumLength(7);
        
        RuleFor(u => u.NewPassword)
            .MaximumLength(20)
            .MinimumLength(7);
    }
}