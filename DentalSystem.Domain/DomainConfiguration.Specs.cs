namespace DentalSystem.Domain
{
    using DentalSystem.Domain;
    using DentalSystem.Domain.Core.AppointmentScheduling.Builders;
    using DentalSystem.Domain.Core.ClientPatientManagement.Builders;
    using FluentAssertions;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class DomainConfigurationSpecs
    {
        [Fact]
        public void AddDomainShouldRegisterFactories()
        {
            // Arrange
            var serviceCollection = new ServiceCollection();

            // Act
            var services = serviceCollection
                .AddDomain()
                .BuildServiceProvider();

            // Assert
            services
                .GetService<IAppointmentBuilder>()
                .Should()
                .NotBeNull();

            services
                .GetService<IClientBuilder>()
                .Should()
                .NotBeNull();
        }
    }
}
