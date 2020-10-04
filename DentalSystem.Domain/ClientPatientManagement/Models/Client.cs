using System;
using DentalSystem.Domain.Common;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.ClientPatientManagement.Models
{
    public class Client : Entity<Guid>, IAggregateRoot
    {
        internal Client()
            : this(default!, default!, default!)
        { }
        
        internal Client(
            FullName fullName,
            PhoneNumber phoneNumber,
            Patient patient)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Patient = patient;
        }

        public FullName FullName { get; private set; }

        public PhoneNumber PhoneNumber { get; private set; }
        
        public Patient Patient { get; private set; }
    }
}