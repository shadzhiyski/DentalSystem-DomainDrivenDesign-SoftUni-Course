using System;

namespace DentalSystem.Application.Core.AppointmentScheduling.Commands
{
    public class AppointmentInputModel
    {
        public string Treatment { get; set; }

        public string DentalTeam { get; set; }

        public DateTimeOffset Start { get; set; }

        public DateTimeOffset End { get; set; }
    }
}