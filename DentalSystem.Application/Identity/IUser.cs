

using DentalSystem.Domain.ClientPatientManagement.Models;

namespace DentalSystem.Application.Identity
{
    public interface IUser
    {
        string Id { get; set; }

        void BecomeClient(Client client);
    }
}