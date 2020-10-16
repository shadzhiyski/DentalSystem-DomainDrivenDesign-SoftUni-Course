using System;
using System.Collections.Generic;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.AppointmentScheduling.Models
{
    public class DentalTeam : Entity<Guid>
    {
        internal DentalTeam(
            string name)
        {
            Name = name;

            Participants = new List<DentalWorker>();
        }

        public string Name { get; private set; }

        public IList<DentalWorker> Participants { get; private set; }
    }
}