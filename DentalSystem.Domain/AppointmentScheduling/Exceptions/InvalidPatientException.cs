using DentalSystem.Domain.Common;

namespace DentalSystem.Domain.AppointmentScheduling.Exceptions
{
    public class InvalidPatientException : BaseDomainException
    {
        public InvalidPatientException() 
            : base()
        { }

        public InvalidPatientException(string error)
            : base(error)
        { }
    }
}