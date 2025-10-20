using AuthService.Application.Dto.UserDataTransferObjects;
using FluentValidation;

namespace AuthService.Api.Validators.Users;

public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
{
    public UserCreateDtoValidator()
    {
        RuleFor(u => u.Username)
            .MaximumLength(50)
            .MinimumLength(3);

        RuleFor(u => u.UserEmail);

        RuleFor(u => u.Password)
            .MaximumLength(20)
            .MinimumLength(7);
    }
}