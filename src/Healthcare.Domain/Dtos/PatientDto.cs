using Healthcare.Domain.Enuns;
using Healthcare.Domain.Patients;

namespace Healthcare.Domain.Dtos
{
    public abstract record PatientDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public EGender Gender { get; set; }
        public AddressDto? Address { get; set; }
   
    }
}