namespace DentalSystem.Application.Identity.Commands.CreateUser
{
    using FluentValidation;
    using static Domain.Common.Models.ModelConstants.Common;
    using static Domain.Common.Models.ModelConstants.PhoneNumber;

    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
        {
            RuleFor(u => u.Email)
                .MinimumLength(MinEmailLength)
                .MaximumLength(MaxEmailLength)
                .EmailAddress()
                .NotEmpty();

            RuleFor(u => u.Password)
                .MaximumLength(MaxNameLength)
                .NotEmpty();

            RuleFor(u => u.FirstName)
                .MinimumLength(MinNameLength)
                .MaximumLength(MaxNameLength)
                .NotEmpty();

            RuleFor(u => u.PhoneNumber)
                .MinimumLength(MinPhoneNumberLength)
                .MaximumLength(MaxPhoneNumberLength)
                .Matches(PhoneNumberRegularExpression)
                .NotEmpty();
        }
    }
}
