using DentalSystem.Domain.Payments.Models;
using DentalSystem.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DentalSystem.Infrastructure.Core.Payments
{
    public interface IPaymentsDbContext : IDbContext
    {
        DbSet<Client> Clients { get; }

        DbSet<CreditCard> CreditCards { get; }

        DbSet<Payment> Payments { get; }
    }
}