using Healthcare.Domain.Dtos;
using System.Collections;

namespace Healthcare.Domain.Patients
{
    public interface IPatientAppService
    {
        public Task<PatientDto> GetPatientDtoAsync(long id);
        public Task<IEnumerable<PatientQuery>> GetAsync();
        public Task DeleteAsync(long id);
        public Task<long> CreateAsync(PatientCreate patientCreate);
    }
}