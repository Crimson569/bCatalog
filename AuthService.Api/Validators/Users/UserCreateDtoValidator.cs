using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Application.Primitives.Patterns;

using FluentValidation;

namespace AuthService.Api.Validators.Users;

public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
{
    public UserCreateDtoValidator()
    {
        RuleFor(u => u.Username)
            .NotEmpty().WithMessage("Username is required.")
            .MaximumLength(50)
            .MinimumLength(3);

        RuleFor(u => u.UserEmail)
            .NotEmpty().WithMessage("Email is required.")
            .Matches(RegexPatterns.Email())
            .WithMessage("Invalid email format.");

        RuleFor(u => u.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MaximumLength(20)
            .MinimumLength(7)
            .Matches(RegexPatterns.Password())
            .WithMessage("Invalid password format.");
    }
}