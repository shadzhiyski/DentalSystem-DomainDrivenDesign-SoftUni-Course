using System;
using DentalSystem.Domain.Common.Exceptions;

namespace DentalSystem.Domain.Common.Models
{
    public class DateTimeRange : ValueObject
    {
        internal DateTimeRange(DateTimeOffset start, DateTimeOffset end)
        {
            Validate(start, end);

            End = end;
            Start = start;
        }

        public DateTimeOffset Start { get; }

        public DateTimeOffset End { get; }

        public int DurationInMinutes => (int)(End - Start).TotalMinutes;

        public bool Overlaps(DateTimeRange dateTimeRange)
            => Start <= dateTimeRange.End
                && End >= dateTimeRange.Start;

        private void Validate(DateTimeOffset start, DateTimeOffset end)
        {
            if (end < start)
            {
                throw new InvalidDateTimeRangeException(
                    $"Start date {start:o} is greather than end date {end:o}"
                );
            }
        }
    }
}