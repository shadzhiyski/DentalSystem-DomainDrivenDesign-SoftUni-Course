using System;
using System.Collections.Generic;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Core.AppointmentScheduling.Models
{
    public class Schedule : Entity<Guid>
    {
        private readonly List<Appointment> _appointments;

        public DateTimeRange DateRange { get; private set; }

        public IReadOnlyList<Appointment> Appointments
            => _appointments.AsReadOnly();

        internal Schedule(
            DateTimeRange dateRange,
            IEnumerable<Appointment> appointments)
        {
            DateRange = dateRange;

            _appointments = new List<Appointment>(appointments);

            MarkConflictingAppointments();
        }

        public Appointment AddNewAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public void DeleteAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        private void MarkConflictingAppointments()
        {
            throw new NotImplementedException();
        }
    }
}