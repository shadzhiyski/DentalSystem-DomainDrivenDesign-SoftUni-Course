using System;
using DentalSystem.Domain.Common;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Core.AppointmentScheduling.Models
{
    public class Appointment : Entity<Guid>, IAggregateRoot
    {
        internal Appointment(
            TreatmentType treatmentType)
            : this(
                default!,
                default!,
                treatmentType,
                default!,
                default!
            )
        { }

        internal Appointment(
            DentalTeam dentalTeam,
            Patient patient,
            TreatmentType treatmentType,
            DateTimeRange timeRange,
            Room room)
        {
            DentalTeam = dentalTeam;
            Patient = patient;
            TreatmentType = treatmentType;
            TimeRange = timeRange;
            Room = room;
        }

        public DentalTeam DentalTeam { get; private set; }

        public Patient Patient { get; private set; }

        public TreatmentType TreatmentType { get; private set; }

        public DateTimeRange TimeRange { get; private set; }

        public Room Room { get; private set; }
    }
}