using DentalSystem.Domain.Core.ClientPatientManagement.Models;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Core.ClientPatientManagement.Builders
{
    public class ClientBuilder : IClientBuilder
    {
        private string _userId = default!;
        private Gender _gender = default!;
        private FullName _fullName = default!;
        private PhoneNumber _phoneNumber = default!;

        public Client Build()
        {
            var patient = new Patient(_gender);
            return new Client(_userId, _fullName, _phoneNumber, patient);
        }

        public IClientBuilder WithUserId(string userId)
        {
            _userId = userId;
            return this;
        }

        public IClientBuilder WithGender(Gender gender)
        {
            _gender = gender;
            return this;
        }

        public IClientBuilder WithNames(string firstName, string lastName)
        {
            _fullName = new FullName(firstName, lastName);
            return this;
        }

        public IClientBuilder WithPhoneNumber(string phoneNumber)
        {
            _phoneNumber = new PhoneNumber(phoneNumber);
            return this;
        }
    }
}