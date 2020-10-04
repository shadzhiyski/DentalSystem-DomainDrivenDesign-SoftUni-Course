using DentalSystem.Application.Identity;
using DentalSystem.Domain.ClientPatientManagement.Exceptions;
using DentalSystem.Domain.ClientPatientManagement.Models;
using Microsoft.AspNetCore.Identity;

namespace DentalSystem.Infrastructure.Identity
{
    public class User : IdentityUser, IUser
    {
        internal User(string email)
            : base(email)
            => this.Email = email;

        public Client? Client { get; private set; }

        public void BecomeClient(Client client)
        {
            if (this.Client != null)
            {
                throw new InvalidClientException($"User '{this.UserName}' is already a client.");
            }

            this.Client = client;
        }
    }
}