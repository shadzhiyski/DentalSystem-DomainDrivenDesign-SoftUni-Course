using DentalSystem.Domain.Core.ClientPatientManagement.Models;
using DentalSystem.Domain.Common;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Core.ClientPatientManagement.Builders
{
    public interface IClientBuilder : IBuilder<Client>
    {
        IClientBuilder WithUserId(string userId);

        IClientBuilder WithNames(string firstName, string lastName);

        IClientBuilder WithPhoneNumber(string phoneNumber);

        IClientBuilder WithGender(Gender gender);
    }
}