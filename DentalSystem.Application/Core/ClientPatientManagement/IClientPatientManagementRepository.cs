using System;
using System.Threading;
using System.Threading.Tasks;
using DentalSystem.Domain.ClientPatientManagement.Models;

namespace DentalSystem.Application.Core.AppointmentScheduling
{
    public interface IClientPatientManagementRepository
    {
        Task<Guid> GetClientId(string userId, CancellationToken cancellationToken = default);

        Task SaveAsync(Client client, CancellationToken cancellationToken);    
    }
}