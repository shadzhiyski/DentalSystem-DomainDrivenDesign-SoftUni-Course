using DentalSystem.Domain.Core.AppointmentScheduling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalSystem.Infrastructure.Core.AppointmentScheduling.Configuration
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable(nameof(Appointment));

            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(e => e.Patient)
                .WithMany()
                .HasForeignKey("PatientId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(e => e.DentalTeam)
                .WithMany()
                .HasForeignKey("DentalTeamId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(e => e.Room)
                .WithMany()
                .HasForeignKey("RoomId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(e => e.TreatmentType)
                .IsRequired();

            builder
                .OwnsOne(e => e.TimeRange, o =>
                {
                    o.Property(op => op.Start);
                    o.Property(op => op.End);
                });
        }
    }
}