using System;
using DentalSystem.Domain.Common.Models;
using DentalSystem.Domain.Core.AppointmentScheduling.Models;

namespace DentalSystem.Domain.Core.AppointmentScheduling.Builders
{
    public class AppointmentBuilder : IAppointmentBuilder
    {
        private Patient _patient = default!;
        private DentalTeam _dentalTeam = default!;
        private DateTimeRange _dateTimeRange = default!;
        private TreatmentType _treatmentType;

        public Appointment Build()
            => new Appointment(
                _dentalTeam,
                _patient,
                _treatmentType,
                _dateTimeRange,
                default!
            );

        public IAppointmentBuilder ForPatient(Patient patient)
        {
            _patient = patient;
            return this;
        }

        public IAppointmentBuilder WithDentalTeam(DentalTeam dentalTeam)
        {
            _dentalTeam = dentalTeam;
            return this;
        }

        public IAppointmentBuilder WithTimeRange(DateTimeOffset start, DateTimeOffset end)
        {
            _dateTimeRange = new DateTimeRange(start, end);
            return this;
        }

        public IAppointmentBuilder WithTreatmentType(TreatmentType treatmentType)
        {
            _treatmentType = treatmentType;
            return this;
        }
    }
}