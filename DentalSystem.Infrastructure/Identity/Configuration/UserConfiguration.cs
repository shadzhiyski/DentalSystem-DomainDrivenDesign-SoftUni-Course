using DentalSystem.Domain.ClientPatientManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalSystem.Infrastructure.Identity.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasOne(u => u.Client)
                .WithOne()
                .HasForeignKey<Client>("UserId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}