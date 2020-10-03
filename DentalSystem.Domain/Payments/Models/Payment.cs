using System;
using DentalSystem.Domain.Common;
using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.Payments.Models
{
    public class Payment : Entity<Guid>, IAggregateRoot
    {
        internal Payment(
            Money amount,
            PaymentMethod paymentMethod,
            Client client,
            CreditCard? creditCard)
        {
            Amount = amount;
            PaymentMethod = paymentMethod;
            Client = client;
            CreditCard = creditCard;
        }

        public Money Amount { get; private set; }

        public PaymentMethod PaymentMethod { get; private set; }

        public Client Client { get; private set; }

        public CreditCard? CreditCard { get; private set; }
    }
}