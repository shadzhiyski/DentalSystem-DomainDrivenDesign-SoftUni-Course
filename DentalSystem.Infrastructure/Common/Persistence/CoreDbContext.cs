using DentalSystem.Domain.Core.AppointmentScheduling.Models;
using DentalSystem.Infrastructure.Core.AppointmentScheduling;
using DentalSystem.Infrastructure.Core.ClientPatientManagement;
using DentalSystem.Infrastructure.Core.Payments;
using DentalSystem.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DentalSystem.Infrastructure.Common.Persistence
{
    public class CoreDbContext : IdentityDbContext<User>,
        IAppointmentSchedulingDbContext,
        IClientPatientManagementDbContext,
        IPaymentsDbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Identity.Configuration.UserConfiguration());

            modelBuilder.ApplyConfiguration(new Core.AppointmentScheduling.Configuration.AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new Core.AppointmentScheduling.Configuration.ClientConfiguration());
            modelBuilder.ApplyConfiguration(new Core.AppointmentScheduling.Configuration.DentalWorkerConfiguration());
            modelBuilder.ApplyConfiguration(new Core.AppointmentScheduling.Configuration.DentalTeamConfiguration());
            modelBuilder.ApplyConfiguration(new Core.AppointmentScheduling.Configuration.PatientConfiguration());
            modelBuilder.ApplyConfiguration(new Core.AppointmentScheduling.Configuration.RoomConfiguration());

            modelBuilder.ApplyConfiguration(new Core.ClientPatientManagement.Configuration.ClientConfiguration());
            modelBuilder.ApplyConfiguration(new Core.ClientPatientManagement.Configuration.PatientConfiguration());

            modelBuilder.ApplyConfiguration(new Core.Payments.Configuration.ClientConfiguration());
            modelBuilder.ApplyConfiguration(new Core.Payments.Configuration.CreditCardConfiguration());
            modelBuilder.ApplyConfiguration(new Core.Payments.Configuration.PaymentConfiguration());
        }

        DbSet<Appointment> IAppointmentSchedulingDbContext.Appointments => Set<Appointment>();

        DbSet<Client> IAppointmentSchedulingDbContext.Clients => Set<Client>();

        DbSet<DentalTeam> IAppointmentSchedulingDbContext.DentalTeams => Set<DentalTeam>();

        DbSet<DentalWorker> IAppointmentSchedulingDbContext.DentalWorkers => Set<DentalWorker>();

        DbSet<Patient> IAppointmentSchedulingDbContext.Patients => Set<Patient>();

        DbSet<Room> IAppointmentSchedulingDbContext.Rooms => Set<Room>();

        DbSet<Domain.Core.ClientPatientManagement.Models.Client> IClientPatientManagementDbContext.Clients
            => Set<Domain.Core.ClientPatientManagement.Models.Client>();

        DbSet<Domain.Core.ClientPatientManagement.Models.Patient> IClientPatientManagementDbContext.Patients
            => Set<Domain.Core.ClientPatientManagement.Models.Patient>();

        DbSet<Domain.Payments.Models.Client> IPaymentsDbContext.Clients
            => Set<Domain.Payments.Models.Client>();

        DbSet<Domain.Payments.Models.CreditCard> IPaymentsDbContext.CreditCards
            => Set<Domain.Payments.Models.CreditCard>();

        DbSet<Domain.Payments.Models.Payment> IPaymentsDbContext.Payments
            => Set<Domain.Payments.Models.Payment>();
    }
}