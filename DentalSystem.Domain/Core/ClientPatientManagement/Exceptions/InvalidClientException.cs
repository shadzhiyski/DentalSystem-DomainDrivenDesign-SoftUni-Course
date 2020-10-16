using DentalSystem.Domain.Common;

namespace DentalSystem.Domain.ClientPatientManagement.Exceptions
{
    public class InvalidClientException : BaseDomainException
    {
        public InvalidClientException() 
            : base()
        { }

        public InvalidClientException(string error)
            : base(error)
        { }
    }
}