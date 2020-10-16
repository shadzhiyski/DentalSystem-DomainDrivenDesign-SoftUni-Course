using System;
using System.Threading;
using System.Threading.Tasks;
using DentalSystem.Application.Core.AppointmentScheduling;
using DentalSystem.Domain.ClientPatientManagement.Models;
using DentalSystem.Infrastructure.Common.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DentalSystem.Infrastructure.Core.ClientPatientManagement.Repositories
{
    internal class ClientPatientManagementRepository : DataRepository<IClientPatientManagementDbContext, Client>,
        IClientPatientManagementRepository
    {
        public ClientPatientManagementRepository(IClientPatientManagementDbContext dbContext)
            : base(dbContext)
        { }

        public async Task<Guid> GetClientId(string userId, CancellationToken cancellationToken = default)
            => (
                await All()
                    .FirstOrDefaultAsync(c => c.UserId == userId)
            )
            .Id;
    }
}