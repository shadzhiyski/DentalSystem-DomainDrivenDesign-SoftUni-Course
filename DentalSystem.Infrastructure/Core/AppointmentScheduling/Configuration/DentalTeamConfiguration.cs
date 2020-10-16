using DentalSystem.Domain.Core.AppointmentScheduling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalSystem.Infrastructure.Core.AppointmentScheduling.Configuration
{
    public class DentalTeamConfiguration : IEntityTypeConfiguration<DentalTeam>
    {
        public void Configure(EntityTypeBuilder<DentalTeam> builder)
        {
            builder.ToTable(nameof(DentalTeam));

            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Name)
                .IsRequired();
        }
    }
}