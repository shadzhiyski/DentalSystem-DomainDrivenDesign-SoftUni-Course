using DentalSystem.Domain.AppointmentScheduling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalSystem.Infrastructure.Core.AppointmentScheduling.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Name)
                .IsRequired();
        }
    }
}