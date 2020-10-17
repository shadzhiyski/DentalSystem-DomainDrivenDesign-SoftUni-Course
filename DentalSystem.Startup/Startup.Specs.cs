namespace DentalSystem.Startup
{
    using DentalSystem.Domain.Core.AppointmentScheduling.Builders;
    using DentalSystem.Domain.Core.ClientPatientManagement.Builders;
    using Infrastructure.Identity;
    using MediatR;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Controllers;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using MyTested.AspNetCore.Mvc;

    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration)
            : base(configuration)
        {
        }

        public void ConfigureTestServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            ValidateServices(services);

            services.ReplaceTransient<UserManager<User>>(_ => IdentityFakes.FakeUserManager);
            services.ReplaceTransient<IJwtTokenGenerator>(_ => JwtTokenGeneratorFakes.FakeJwtTokenGenerator);
        }

        private static void ValidateServices(IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();

            provider.GetRequiredService<IAppointmentBuilder>();
            provider.GetRequiredService<IMediator>();
            provider.GetRequiredService<IClientBuilder>();
            provider.GetRequiredService<IControllerFactory>();
        }
    }
}
