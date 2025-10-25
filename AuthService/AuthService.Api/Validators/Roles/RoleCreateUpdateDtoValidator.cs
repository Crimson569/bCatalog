using AuthService.Application.Dto.RoleDataTransferObjects;
using FluentValidation;

namespace AuthService.Api.Validators.Roles;

public class RoleCreateUpdateDtoValidator : AbstractValidator<RoleCreateUpdateDto>
{
    public RoleCreateUpdateDtoValidator()
    {
        RuleFor(r => r.RoleName)
            .NotEmpty().WithMessage("Role name is required.")
            .MinimumLength(3)
            .MaximumLength(30);
    }
}