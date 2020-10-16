namespace DomainSystem.Domain.Common.Models
{
    using System;
    using DentalSystem.Domain.Common.Models;
    using DentalSystem.Domain.Core.AppointmentScheduling.Models;
    using FluentAssertions;
    using Xunit;

    public class EntitySpecs
    {
        [Fact]
        public void EntitiesWithEqualIdsShouldBeEqual()
        {
            // Arrange
            var id = Guid.NewGuid();
            var first = new DentalTeam(name: "Dental Team 1").SetId(id);
            var second = new DentalTeam(name: "Dental Team 2").SetId(id);

            // Act
            var result = first == second;

            // Arrange
            result.Should().BeTrue();
        }

        [Fact]
        public void EntitiesWithDifferentIdsShouldNotBeEqual()
        {
            // Arrange
            var first = new DentalTeam(name: "Dental Team 1").SetId(Guid.NewGuid());
            var second = new DentalTeam(name: "Dental Team 2").SetId(Guid.NewGuid());

            // Act
            var result = first == second;

            // Arrange
            result.Should().BeFalse();
        }
    }

    internal static class EntityExtensions
    {
        public static TEntity SetId<TEntity>(this TEntity entity, Guid id)
            where TEntity : Entity<Guid>
            => (entity.SetId<Guid>(id) as TEntity)!;

        private static Entity<T> SetId<T>(this Entity<T> entity, Guid id)
            where T : struct
        {
            entity
                .GetType()
                .BaseType!
                .GetProperty(nameof(Entity<T>.Id))!
                .GetSetMethod(true)!
                .Invoke(entity, new object[] { id });

            return entity;
        }
    }
}
