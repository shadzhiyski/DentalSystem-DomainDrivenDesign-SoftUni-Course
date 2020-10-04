

using DentalSystem.Domain.ClientPatientManagement.Models;

namespace DentalSystem.Application.Identity
{
    public interface IUser
    {
        void BecomeClient(Client client);
    }
}