using DentalSystem.Domain.ClientPatientManagement.Models;
using DentalSystem.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DentalSystem.Infrastructure.Core.ClientPatientManagement
{
    public interface IClientPatientManagementDbContext : IDbContext
    {
        DbSet<Client> Clients { get; }

        DbSet<Patient> Patients { get; }
    }
}