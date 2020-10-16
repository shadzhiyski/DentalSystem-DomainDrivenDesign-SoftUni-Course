using DentalSystem.Domain.ClientPatientManagement.Models;
using DentalSystem.Domain.Common;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.ClientPatientManagement.Builders
{
    public interface IClientBuilder : IFactory<Client>
    {
        IClientBuilder WithUserId(string userId);

        IClientBuilder WithNames(string firstName, string lastName);

        IClientBuilder WithPhoneNumber(string phoneNumber);

        IClientBuilder WithGender(Gender gender);
    }
}