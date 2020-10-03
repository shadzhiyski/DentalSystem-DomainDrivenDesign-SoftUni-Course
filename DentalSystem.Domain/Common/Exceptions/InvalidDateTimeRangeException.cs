using DentalSystem.Domain.Common;

namespace DentalSystem.Domain.Common.Exceptions
{
    public class InvalidDateTimeRangeException : BaseDomainException
    {
        public InvalidDateTimeRangeException() 
            : base()
        { }

        public InvalidDateTimeRangeException(string error)
            : base(error)
        { }
    }
}