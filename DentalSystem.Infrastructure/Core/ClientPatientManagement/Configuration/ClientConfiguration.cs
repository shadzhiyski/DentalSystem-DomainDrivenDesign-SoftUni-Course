using DentalSystem.Domain.ClientPatientManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalSystem.Infrastructure.Core.ClientPatientManagement.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .OwnsOne(e => e.FullName, o =>
                {
                    o.Property(op => op.FirstName);
                    o.Property(op => op.LastName);
                });
            
            builder
                .OwnsOne(e => e.PhoneNumber, o => o.Property(op => op.Number));
        }
    }
}