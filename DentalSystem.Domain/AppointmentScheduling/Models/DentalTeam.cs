using System;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.AppointmentScheduling.Models
{
    public class DentalTeam : Entity<Guid>
    {
        internal DentalTeam(
            string name,
            Room room)
        {
            Name = name;
            Room = room;
        }

        public string Name { get; private set; }
        
        public Room Room { get; private set; }
    }
}