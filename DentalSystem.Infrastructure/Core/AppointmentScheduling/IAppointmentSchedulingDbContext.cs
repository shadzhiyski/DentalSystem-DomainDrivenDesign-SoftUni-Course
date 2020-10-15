using DentalSystem.Domain.AppointmentScheduling.Models;
using Microsoft.EntityFrameworkCore;

namespace DentalSystem.Infrastructure.Core.AppointmentScheduling
{
    public interface IAppointmentSchedulingDbContext
    {
        DbSet<Appointment> Appointments { get; }

        DbSet<Client> Clients { get; }

        DbSet<DentalTeam> DentalTeams { get; }

        DbSet<DentalWorker> DentalWorkers { get; }

        DbSet<Patient> Patients { get; }

        DbSet<Room> Rooms { get; }
    }
}