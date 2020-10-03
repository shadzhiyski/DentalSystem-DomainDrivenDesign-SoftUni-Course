using System;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.AppointmentScheduling.Models
{
    public class DentalTeam : Entity<Guid>
    {
        internal DentalTeam(
            string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}