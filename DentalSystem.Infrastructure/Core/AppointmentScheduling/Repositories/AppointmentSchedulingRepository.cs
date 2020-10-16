using System;
using System.Threading;
using System.Threading.Tasks;
using DentalSystem.Application.Core.AppointmentScheduling;
using DentalSystem.Domain.Core.AppointmentScheduling.Models;
using DentalSystem.Infrastructure.Common.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DentalSystem.Infrastructure.Core.AppointmentScheduling.Repositories
{
    internal class AppointmentSchedulingRepository : DataRepository<IAppointmentSchedulingDbContext, Appointment>,
        IAppointmentSchedulingRepository
    {
        public AppointmentSchedulingRepository(IAppointmentSchedulingDbContext db)
            : base(db)
        {
        }

        public async Task<DentalTeam> GetDentalTeam(string dentalTeam, CancellationToken cancellationToken)
            => await Data.DentalTeams.FirstOrDefaultAsync(dt => dt.Name == dentalTeam);

        public async Task<Patient> GetPatientByUserId(string userId, CancellationToken cancellationToken)
            => (
                await Data.Clients.FirstOrDefaultAsync(dt => dt.UserId == userId)
            )
            .Patient;

        public Task<TreatmentType> GetTreatment(string treatment, CancellationToken cancellationToken)
            => Task.FromResult(
                (TreatmentType)Enum.Parse(typeof(TreatmentType), treatment)
            );
    }
}