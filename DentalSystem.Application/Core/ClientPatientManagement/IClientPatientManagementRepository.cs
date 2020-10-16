using System;
using System.Threading;
using System.Threading.Tasks;
using DentalSystem.Application.Common.Contracts;
using DentalSystem.Domain.Core.ClientPatientManagement.Models;

namespace DentalSystem.Application.Core.AppointmentScheduling
{
    public interface IClientPatientManagementRepository : IRepository<Client>
    {
        Task<Guid> GetClientId(string userId, CancellationToken cancellationToken = default);
    }
}