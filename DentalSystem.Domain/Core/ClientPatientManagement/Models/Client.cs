using System;
using DentalSystem.Domain.Common;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Core.ClientPatientManagement.Models
{
    public class Client : Entity<Guid>, IAggregateRoot
    {
        internal Client()
            : this(default!, default!, default!, default!)
        { }

        internal Client(
            string userId,
            FullName fullName,
            PhoneNumber phoneNumber,
            Patient patient)
        {
            UserId = userId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Patient = patient;
        }

        public string UserId { get; set; }

        public FullName FullName { get; private set; }

        public PhoneNumber PhoneNumber { get; private set; }

        public Patient Patient { get; private set; }
    }
}