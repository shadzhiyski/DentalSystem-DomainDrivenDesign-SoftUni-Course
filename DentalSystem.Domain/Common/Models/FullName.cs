namespace DentalSystem.Domain.Common.Models
{
    public class FullName : ValueObject
    {
        internal FullName(
            string firstName, 
            string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        
        public string LastName { get; }
    }
}