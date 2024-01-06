using Healthcare.Domain.Enuns;
using Healthcare.Domain.Patients;

namespace Healthcare.Domain.Dtos
{
    public record PatientCreate
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public EGender Gender { get; set; }
        public AddressDto? Address { get; set; }

        public static implicit operator Patient(PatientCreate create)
            => new(create.FirstName, create.LastName, create.Gender, create.Address);   

    }
}
