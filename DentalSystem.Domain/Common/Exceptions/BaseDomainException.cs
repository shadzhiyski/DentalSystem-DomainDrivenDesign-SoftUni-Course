using System;

namespace DentalSystem.Domain.Common
{
    public abstract class BaseDomainException : Exception
    {
        public BaseDomainException() 
            : this(default!)
        { }

        public BaseDomainException(string error)
        {
            Error = error;
        }

        private string? error;

        public string Error
        {
            get => this.error ?? base.Message;
            set => this.error = value;
        }
    }
}