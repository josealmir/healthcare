using Healthcare.Domain.Dtos;

namespace Healthcare.Domain.Patients
{
    public interface IPatientAppService
    {
        public Task<PatientDto> GetPatientDtoAsync(long id);
    }
}