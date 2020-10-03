using DentalSystem.Application.Identity;
using DentalSystem.Domain.AppointmentScheduling.Exceptions;
using DentalSystem.Domain.AppointmentScheduling.Models;
using Microsoft.AspNetCore.Identity;

namespace DentalSystem.Infrastructure.Identity
{
    public class User : IdentityUser, IUser
    {
        internal User(string email)
            : base(email)
            => this.Email = email;

        public Patient? Patient { get; private set; }

        public void BecomePatient(Patient dealer)
        {
            if (this.Patient != null)
            {
                throw new InvalidPatientException($"User '{this.UserName}' is already a patient.");
            }

            this.Patient = dealer;
        }
    }
}