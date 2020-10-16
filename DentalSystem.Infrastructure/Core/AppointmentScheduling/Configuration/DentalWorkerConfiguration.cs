using DentalSystem.Domain.AppointmentScheduling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalSystem.Infrastructure.Core.AppointmentScheduling.Configuration
{
    public class DentalWorkerConfiguration : IEntityTypeConfiguration<DentalWorker>
    {
        public void Configure(EntityTypeBuilder<DentalWorker> builder)
        {
            builder.ToTable(nameof(DentalWorker));

            builder
                .HasKey(e => e.Id);

            builder
                .OwnsOne(e => e.FullName, o =>
                {
                    o.Property(op => op.FirstName);
                    o.Property(op => op.LastName);
                });

            builder
                .Property(e => e.JobType)
                .IsRequired();

            builder
                .HasOne(e => e.DentalTeam)
                .WithMany(e => e.Participants)
                .HasForeignKey("DentalTeamId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}