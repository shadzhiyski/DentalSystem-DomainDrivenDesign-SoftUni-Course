using DentalSystem.Domain.AppointmentScheduling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalSystem.Infrastructure.Core.AppointmentScheduling.Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable(nameof(Patient));

            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Gender)
                .HasColumnName(nameof(Patient.Gender))
                .IsRequired();

            builder
                .HasOne(e => e.Client)
                .WithOne(e => e.Patient)
                .HasForeignKey<Patient>("ClientId");
        }
    }
}