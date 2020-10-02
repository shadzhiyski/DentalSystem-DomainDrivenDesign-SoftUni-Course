using System.Collections.Generic;

namespace DentalSystem.Domain.Common.Models
{
    public interface IEntity
    {
        IReadOnlyCollection<IDomainEvent> Events { get; }

        void ClearEvents();
    }
}