using System.Threading.Tasks;
using DentalSystem.Application.Core.AppointmentScheduling.Commands.RequestAppointment;
using DentalSystem.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DentalSystem.Web.Features
{
    public class AppointmentSchedulingController : ApiController
    {
        [HttpPost]
        [Route(nameof(RequestAppointment))]
        public async Task<IActionResult> RequestAppointment(
            RequestAppointmentCommand command)
            => await this.Send(command);
    }
}