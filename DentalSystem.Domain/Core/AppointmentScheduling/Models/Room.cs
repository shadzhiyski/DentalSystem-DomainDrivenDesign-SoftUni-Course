using System;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Core.AppointmentScheduling.Models
{
    public class Room : Entity<Guid>
    {
        internal Room(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}