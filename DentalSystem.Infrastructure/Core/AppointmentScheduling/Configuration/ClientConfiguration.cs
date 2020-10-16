using DentalSystem.Domain.Core.AppointmentScheduling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalSystem.Infrastructure.Core.AppointmentScheduling.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable(nameof(Client));

            builder
                .HasKey(e => e.Id);

            builder
                .HasOne<Domain.ClientPatientManagement.Models.Client>()
                .WithOne()
                .HasForeignKey<Client>(e => e.Id);

            builder
                .OwnsOne(e => e.FullName, o =>
                {
                    o.Property(op => op.FirstName);
                    o.Property(op => op.LastName);
                });
        }
    }
}