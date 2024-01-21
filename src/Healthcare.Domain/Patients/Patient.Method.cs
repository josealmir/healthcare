using Healthcare.Domain.Dtos;

namespace Healthcare.Domain.Patients
{
    public sealed partial class Patient
    {
        public static explicit operator PatientQuery(Patient patient)
            => new()
            {
                Id = patient.Id,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                UpdatedIn = patient.UpdatedIn,
            };
        
        public static implicit operator PatientUpdate(Patient patient)
            => new()
            {
                Gender = patient.Gender,
                LastName = patient.LastName,
                FirstName = patient.FirstName,
                Address = patient.Address,
            };
    }
}