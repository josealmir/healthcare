
using Healthcare.Domain.Patients;

namespace Healthcare.Domain.Dtos
{
    public record PatientUpdate : PatientDto
    {
        public long Id { get; set; }
        
        public static implicit operator Patient(PatientUpdate create)
            => new(create.FirstName, create.LastName, create.Gender, create.Address ?? new AddressDto());
    }
}