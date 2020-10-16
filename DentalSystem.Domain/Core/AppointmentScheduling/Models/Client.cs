using System;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Core.AppointmentScheduling.Models
{
    public class Client : Entity<Guid>
    {
        internal Client()
            : this(default!, default!, default!)
        { }

        internal Client(
            string userId,
            FullName fullName,
            Patient patient)
        {
            UserId = userId;
            FullName = fullName;
            Patient = patient;
        }

        public string UserId { get; private set; }

        public FullName FullName { get; private set; }

        public Patient Patient { get; private set; }
    }
}