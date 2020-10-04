using System;
using DentalSystem.Domain.Common;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.ClientPatientManagement.Models
{
    public class Client : Entity<Guid>, IAggregateRoot
    {
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