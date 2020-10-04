using System;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.AppointmentScheduling.Models
{
    public class DentalWorker : Entity<Guid>
    {
        internal DentalWorker(DentalWorkerJobType jobType)
            : this(default!, jobType, default!)
        { }

        internal DentalWorker(
            FullName fullName, 
            DentalWorkerJobType jobType,
            DentalTeam dentalTeam)
        {
            FullName = fullName;
            JobType = jobType;
            DentalTeam = dentalTeam;
        }

        public FullName FullName { get; private set; }
        
        public DentalWorkerJobType JobType { get; private set; }
        
        public DentalTeam DentalTeam { get; private set; }
    }
}