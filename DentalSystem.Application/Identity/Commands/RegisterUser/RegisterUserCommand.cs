namespace DentalSystem.Application.Identity.Commands.CreateUser
{
    using System.Threading;
    using System.Threading.Tasks;
    using Common;
    using DentalSystem.Application.Core.AppointmentScheduling;
    using DentalSystem.Domain.ClientPatientManagement.Builders;
    using MediatR;

    public class RegisterUserCommand : UserInputModel, IRequest<Result>
    {
        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string PhoneNumber { get; set; } = default!;

        public class CreateUserCommandHandler : IRequestHandler<RegisterUserCommand, Result>
        {
            private readonly IIdentity _identity;
            private readonly IClientBuilder _clientBuilder;
            private readonly IClientPatientManagementRepository _clientPatientManagementRepository;

            public CreateUserCommandHandler(
                IIdentity identity, 
                IClientBuilder clientBuilder, 
                IClientPatientManagementRepository clientPatientManagementRepository)
            {
                _identity = identity;
                _clientBuilder = clientBuilder;
                _clientPatientManagementRepository = clientPatientManagementRepository;
            }

            public async Task<Result> Handle(
                RegisterUserCommand request,
                CancellationToken cancellationToken)
            {
                var result = await _identity.RegisterAsync(request);

                if (!result.Succeeded)
                {
                    return result;
                }

                var user = result.Data;

                var client = _clientBuilder
                    .WithUserId(user.Id)
                    .WithNames(request.FirstName, request.LastName)
                    .WithPhoneNumber(request.PhoneNumber)
                    .Build();

                user.BecomeClient(client);

                await _clientPatientManagementRepository.SaveAsync(client, cancellationToken);

                return result;
            }
        }
    }
}