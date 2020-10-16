using System;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.AppointmentScheduling.Models
{
    public class Patient : Entity<Guid>
    {
        internal Patient(
            Gender gender)
            : this(gender, default!)
        { }

        internal Patient(
            Gender gender,
            Client client)
        {
            Gender = gender;
            Client = client;
        }
        
        public Gender Gender { get; private set; }
        
        public Client Client { get; private set; }
    }
}