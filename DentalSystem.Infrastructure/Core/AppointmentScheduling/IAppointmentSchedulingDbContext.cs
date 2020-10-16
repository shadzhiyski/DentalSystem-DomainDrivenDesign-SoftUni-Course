using DentalSystem.Domain.Core.AppointmentScheduling.Models;
using DentalSystem.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DentalSystem.Infrastructure.Core.AppointmentScheduling
{
    public interface IAppointmentSchedulingDbContext : IDbContext
    {
        DbSet<Appointment> Appointments { get; }

        DbSet<Client> Clients { get; }

        DbSet<DentalTeam> DentalTeams { get; }

        DbSet<DentalWorker> DentalWorkers { get; }

        DbSet<Patient> Patients { get; }

        DbSet<Room> Rooms { get; }
    }
}