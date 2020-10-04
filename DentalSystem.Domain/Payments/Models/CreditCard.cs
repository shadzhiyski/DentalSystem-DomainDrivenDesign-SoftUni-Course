using System;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Payments.Models
{
    public class CreditCard : Entity<Guid>
    {
        internal CreditCard()
            : this(default!, default!, default!, default!, default!)
        { }

        internal CreditCard(
            string number,
            string cvcCode,
            DateTimeOffset expirationDate,
            Client holder,
            bool isMain)
        {
            Number = number;
            CvcCode = cvcCode;
            ExpirationDate = expirationDate;
            Holder = holder;
            IsMain = isMain;
        }

        public string Number { get; private set; }

        public string CvcCode { get; private set; }

        public DateTimeOffset ExpirationDate { get; private set; }

        public Client Holder { get; private set; }

        public bool IsMain { get; private set; }
    }
}