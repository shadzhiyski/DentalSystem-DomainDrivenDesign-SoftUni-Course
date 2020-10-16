using System;
using DentalSystem.Domain.Common;
using DentalSystem.Domain.Core.AppointmentScheduling.Models;

namespace DentalSystem.Domain.Core.AppointmentScheduling.Builders
{
    public interface IAppointmentBuilder : IBuilder<Appointment>
    {
        IAppointmentBuilder ForPatient(Patient patient);

        IAppointmentBuilder WithTreatmentType(TreatmentType treatmentType);

        IAppointmentBuilder WithDentalTeam(DentalTeam dentalTeam);

        IAppointmentBuilder WithTimeRange(DateTimeOffset start, DateTimeOffset end);
    }
}