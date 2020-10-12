namespace DentalSystem.Application.Identity.Commands.LoginUser
{
    using System.Threading;
    using System.Threading.Tasks;
    using Common;
    using DentalSystem.Application.Core.AppointmentScheduling;
    using MediatR;

    public class LoginUserCommand : UserInputModel, IRequest<Result<LoginOutputModel>>
    {
        public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, Result<LoginOutputModel>>
        {
            private readonly IIdentity identity;
            private readonly IClientPatientManagementRepository clientPatientManagementRepository;

            public LoginUserCommandHandler(
                IIdentity identity, 
                IClientPatientManagementRepository clientPatientManagementRepository)
            {
                this.identity = identity;
                this.clientPatientManagementRepository = clientPatientManagementRepository;
            }

            public async Task<Result<LoginOutputModel>> Handle(
                LoginUserCommand request,
                CancellationToken cancellationToken)
            {
                var result = await this.identity.LoginAsync(request);

                if (!result.Succeeded)
                {
                    return result.Errors;
                }

                var user = result.Data;

                var clientId = await this.clientPatientManagementRepository.GetClientId(user.UserId, cancellationToken);

                return new LoginOutputModel(user.Token, clientId);
            }
        }
    }
}
