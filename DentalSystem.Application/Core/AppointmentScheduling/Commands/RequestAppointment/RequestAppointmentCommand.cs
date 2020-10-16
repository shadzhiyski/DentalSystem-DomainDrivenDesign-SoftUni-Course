using System.Threading;
using System.Threading.Tasks;
using DentalSystem.Application.Common;
using DentalSystem.Application.Common.Contracts;
using DentalSystem.Domain.Core.AppointmentScheduling.Builders;
using MediatR;

namespace DentalSystem.Application.Core.AppointmentScheduling.Commands.RequestAppointment
{
    public class RequestAppointmentCommand : AppointmentInputModel, IRequest<Result>
    {
        public class RequestAppointmentCommandHandler : IRequestHandler<RequestAppointmentCommand, Result>
        {
            private readonly IAppointmentSchedulingRepository _appointmentSchedulingRepository;
            private readonly ICurrentUser _currentUser;
            private readonly IAppointmentBuilder _appointmentBuilder;

            public RequestAppointmentCommandHandler(
                IAppointmentSchedulingRepository appointmentSchedulingRepository,
                ICurrentUser currentUser,
                IAppointmentBuilder appointmentBuilder)
            {
                _appointmentSchedulingRepository = appointmentSchedulingRepository;
                _currentUser = currentUser;
                _appointmentBuilder = appointmentBuilder;
            }

            public async Task<Result> Handle(
                RequestAppointmentCommand request,
                CancellationToken cancellationToken)
            {
                var currentUserId = _currentUser.UserId;
                var currentPatient = await _appointmentSchedulingRepository.GetPatientByUserId(
                    currentUserId, cancellationToken);

                var treatmentType = await _appointmentSchedulingRepository.GetTreatment(
                    request.Treatment, cancellationToken);

                var dentalTeam = await _appointmentSchedulingRepository.GetDentalTeam(
                    request.DentalTeam, cancellationToken);

                var appointment = _appointmentBuilder
                    .ForPatient(currentPatient)
                    .WithTreatmentType(treatmentType)
                    .WithDentalTeam(dentalTeam)
                    .WithTimeRange(request.Start, request.End)
                    .Build();

                await _appointmentSchedulingRepository.SaveAsync(appointment, cancellationToken);

                return Result<string>.SuccessWith("Appointment successfully requested.");
            }
        }
    }
}