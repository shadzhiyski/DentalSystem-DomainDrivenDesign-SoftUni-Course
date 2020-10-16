namespace DentalSystem.Domain.ClientPatientManagement.Models
{
    using System.Text.RegularExpressions;
    using CarRentalSystem.Domain.Common.Models;
    using Common;
    using Common.Models;
    using Exceptions;
    using static Common.Models.ModelConstants.PhoneNumber;

    public class PhoneNumber : ValueObject
    {
        internal PhoneNumber(string number)
        {
            Validate(number);

            if (!Regex.IsMatch(number, PhoneNumberRegularExpression))
            {
                throw new InvalidPhoneNumberException(
                    "Phone number must start with a '+' and contain only digits afterwards."
                );
            }

            Number = number;
        }

        public string Number { get; }

        public static implicit operator string(PhoneNumber number) => number.Number;

        public static implicit operator PhoneNumber(string number) => new PhoneNumber(number);

        private void Validate(string phoneNumber) 
            => Guard.ForStringLength<InvalidPhoneNumberException>(
                phoneNumber,
                MinPhoneNumberLength,
                MaxPhoneNumberLength,
                nameof(PhoneNumber)
            );
    }
}
