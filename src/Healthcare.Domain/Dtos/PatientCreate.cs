using Healthcare.Domain.Enuns;
using Healthcare.Domain.Patients;

namespace Healthcare.Domain.Dtos
{
    public record PatientCreate : PatientDto
    {
        public static implicit operator Patient(PatientCreate create)
            => new(create.FirstName, create.LastName, create.Gender, create.Address);
    }
}
