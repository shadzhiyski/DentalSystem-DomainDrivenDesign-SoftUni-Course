using DentalSystem.Domain.Common.Models;

namespace DentalSystem.Domain.ClientPatientManagement.Models
{
    public class Patient
    {
        internal Patient(
            Gender gender,
            Client client)
        {
            Gender = gender;
            Client = client;
        }
        
        public Gender Gender { get; private set; }
        
        public Client Client { get; private set; }
    }
}