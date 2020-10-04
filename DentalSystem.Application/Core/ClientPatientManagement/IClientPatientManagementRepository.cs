using System.Threading;
using System.Threading.Tasks;
using DentalSystem.Domain.ClientPatientManagement.Models;

namespace DentalSystem.Application.Core.AppointmentScheduling
{
    public interface IClientPatientManagementRepository
    {
        Task SaveAsync(Client client, CancellationToken cancellationToken);    
    }
}