using DentalSystem.Domain.Common;

namespace DentalSystem.Domain.Core.ClientPatientManagement.Exceptions
{
    public class InvalidPhoneNumberException : BaseDomainException
    {
        public InvalidPhoneNumberException() 
            : base()
        { }

        public InvalidPhoneNumberException(string error)
            : base(error)
        { }
    }
}