using DentalSystem.Domain.Payments.Models;
using Microsoft.EntityFrameworkCore;

namespace DentalSystem.Infrastructure.Core.Payments
{
    public interface IPaymentsDbContext
    {
        DbSet<Client> Clients { get; }

        DbSet<CreditCard> CreditCards { get; }

        DbSet<Payment> Payments { get; }
    }
}