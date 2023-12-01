using Healthcare.Domain.Dtos;

namespace Healthcare.Domain.Patients
{
    public sealed partial class Patient
    {
        public static implicit operator PatientDto(Patient patient)
            => new ()
            {
                Id = patient.Id,
                FullName = $"{patient.FirstName} {patient.LastName}",
                Gender = patient.Gender,
            };

        public static explicit operator PatientQuery(Patient patient)
            => new()
            {
                Id = patient.Id,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                CreatedIn = patient.CreatedIn,
            };

    }
}