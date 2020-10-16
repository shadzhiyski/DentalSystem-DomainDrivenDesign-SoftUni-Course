using System.Threading;
using System.Threading.Tasks;
using DentalSystem.Application.Common.Contracts;
using DentalSystem.Domain.Core.AppointmentScheduling.Models;

namespace DentalSystem.Application.Core.AppointmentScheduling
{
    public interface IAppointmentSchedulingRepository : IRepository<Appointment>
    {
        Task<Patient> GetPatientByUserId(string currentUserId, CancellationToken cancellationToken);

        Task<TreatmentType> GetTreatment(string treatment, CancellationToken cancellationToken);

        Task<DentalTeam> GetDentalTeam(string dentalTeam, CancellationToken cancellationToken);
    }
}