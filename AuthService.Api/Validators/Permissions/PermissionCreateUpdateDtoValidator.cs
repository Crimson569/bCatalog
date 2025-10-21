using AuthService.Application.Dto.PermissionDataTransferObjects;
using FluentValidation;

namespace AuthService.Api.Validators.Permissions;

public class PermissionCreateUpdateDtoValidator : AbstractValidator<PermissionCreateUpdateDto>
{
    public PermissionCreateUpdateDtoValidator()
    {
        RuleFor(p => p.PermissionName)
            .NotEmpty().WithMessage("Permission name is required.")
            .MinimumLength(5)
            .MaximumLength(100);
    }
}