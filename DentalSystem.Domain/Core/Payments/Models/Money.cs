using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Core.Payments.Models
{
    public class Money : ValueObject
    {
        internal Money(decimal value, Currency currency)
        {
            Value = value;
            Currency = currency;
        }

        public decimal Value { get; private set; }

        public Currency Currency { get; private set; }
    }
}