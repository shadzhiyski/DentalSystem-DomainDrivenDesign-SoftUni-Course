namespace DentalSystem.Infrastructure
{
    using System;
    using System.Reflection;
    using AutoMapper;
    using Common.Persistence;
    using DentalSystem.Application.Core.AppointmentScheduling;
    using DentalSystem.Infrastructure.Core.AppointmentScheduling;
    using FakeItEasy;
    using FluentAssertions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class InfrastructureConfigurationSpecs
    {
        [Fact]
        public void AddRepositoriesShouldRegisterRepositories()
        {
            // Arrange
            var serviceCollection = new ServiceCollection()
                .AddDbContext<CoreDbContext>(opts => opts
                    .UseInMemoryDatabase(Guid.NewGuid().ToString()))
                .AddTransient(_ => A.Fake<IAppointmentSchedulingDbContext>());

            // Act
            var services = serviceCollection
                .AddAutoMapper(Assembly.GetExecutingAssembly())
                .AddRepositories()
                .BuildServiceProvider();

            // Assert
            services
                .GetService<IAppointmentSchedulingRepository>()
                .Should()
                .NotBeNull();
        }
    }
}
