namespace DentalSystem.Domain.Common.Models
{
    using FluentAssertions;
    using Xunit;

    public class ValueObjectSpecs
    {
        [Fact]
        public void ValueObjectsWithEqualPropertiesShouldBeEqual()
        {
            // Arrange
            var first = new FullName("John", "Doe");
            var second = new FullName("John", "Doe");

            // Act
            var result = first == second;

            // Arrange
            result.Should().BeTrue();
        }

        [Fact]
        public void ValueObjectsWithDifferentPropertiesShouldNotBeEqual()
        {
            // Arrange
            var first = new FullName("John", "Doe");
            var second = new FullName("Jane", "Doe");

            // Act
            var result = first == second;

            // Arrange
            result.Should().BeFalse();
        }
    }
}
