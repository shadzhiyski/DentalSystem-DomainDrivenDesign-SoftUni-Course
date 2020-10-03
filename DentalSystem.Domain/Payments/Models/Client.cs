using System;
using System.Collections.Generic;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Payments.Models
{
    public class Client : Entity<Guid>
    {
        internal Client(
            FullName fullName,
            string emailAddress)
        {
            FullName = fullName;
            EmailAddress = emailAddress;

            CreditCards = new List<CreditCard>();
            Payments = new List<Payment>();
        }

        public FullName FullName { get; private set; }

        public string EmailAddress { get; private set; }

        public IList<CreditCard> CreditCards { get; private set; }

        public IList<Payment> Payments { get; private set; }
    }
}