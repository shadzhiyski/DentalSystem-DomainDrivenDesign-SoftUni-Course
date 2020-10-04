using DentalSystem.Domain.Payments.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalSystem.Infrastructure.Core.Payments.Configuration
{
    public class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder
                .HasKey(e => e.Id);
            
            builder
                .Property(e => e.Number)
                .IsRequired();
            
            builder
                .Property(e => e.CvcCode)
                .IsRequired();

            builder
                .Property(e => e.ExpirationDate)
                .IsRequired();
            
            builder
                .HasOne(e => e.Holder)
                .WithMany(e => e.CreditCards)
                .HasForeignKey("HolderId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(e => e.IsMain)
                .IsRequired();
        }
    }
}