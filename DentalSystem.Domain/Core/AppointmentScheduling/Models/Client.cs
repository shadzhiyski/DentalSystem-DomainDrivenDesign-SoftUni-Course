using System;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Core.AppointmentScheduling.Models
{
    public class Client : Entity<Guid>
    {
        internal Client()
            : this(default!, default!)
        { }

        internal Client(
            FullName fullName,
            Patient patient)
        {
            FullName = fullName;
            Patient = patient;
        }

        public FullName FullName { get; private set; }
        
        public Patient Patient { get; private set; }
    }
}