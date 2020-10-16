using DentalSystem.Domain.Core.Payments.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalSystem.Infrastructure.Core.Payments.Configuration
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable(nameof(Payment));

            builder
                .HasKey(e => e.Id);

            builder
                .OwnsOne(e => e.Amount, o =>
                {
                    o.Property(e => e.Value).HasColumnName(nameof(Payment.Amount));
                    o.Property(e => e.Currency);
                });

            builder
                .Property(e => e.PaymentMethod)
                .IsRequired();

            builder
                .HasOne(e => e.Client)
                .WithMany(e => e.Payments)
                .HasForeignKey("ClientId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(e => e.CreditCard)
                .WithMany()
                .HasForeignKey("CreditCardId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}