namespace DentalSystem.Application.Core.AppointmentScheduling.Commands.RequestAppointment
{
    using DentalSystem.Domain.Core.AppointmentScheduling.Models;
    using FluentValidation;

    public class RequestAppointmentCommandValidator : AbstractValidator<AppointmentInputModel>
    {
        public RequestAppointmentCommandValidator()
        {
            RuleFor(m => m.Treatment)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty();

            RuleFor(model => model.Treatment)
                .IsEnumName(typeof(TreatmentType));

            RuleFor(m => m.DentalTeam)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty();

            RuleFor(m => m.Start)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty();

            RuleFor(m => m.End)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty();

            RuleFor(model => model.End)
                .GreaterThan(model => model.Start);
        }
    }
}
