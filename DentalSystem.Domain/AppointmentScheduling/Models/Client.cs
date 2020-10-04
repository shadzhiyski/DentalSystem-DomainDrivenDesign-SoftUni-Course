using System;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.AppointmentScheduling.Models
{
    public class Client : Entity<Guid>
    {
        internal Client()
            : this(default!)
        { }

        internal Client(
            FullName fullName)
        {
            FullName = fullName;
        }

        public FullName FullName { get; private set; }
    }
}