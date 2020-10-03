using DentalSystem.Domain.AppointmentScheduling.Models;

namespace DentalSystem.Application.Identity
{
    public interface IUser
    {
        void BecomePatient(Patient patient);
    }
}