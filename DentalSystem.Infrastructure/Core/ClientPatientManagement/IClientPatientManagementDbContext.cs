using DentalSystem.Domain.ClientPatientManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DentalSystem.Infrastructure.Core.ClientPatientManagement
{
    public interface IClientPatientManagementDbContext
    {
        DbSet<Client> Clients { get; }

        DbSet<Patient> Patients { get; }
    }
}