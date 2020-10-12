using System;

namespace DentalSystem.Application.Identity.Commands.LoginUser
{
    public class LoginOutputModel
    {
        public LoginOutputModel(string token, Guid clientId)
        {
            Token = token;
            ClientId = clientId;
        }

        public Guid ClientId { get; }

        public string Token { get; }
    }
}
