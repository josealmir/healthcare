using Healthcare.Domain.Dtos;

namespace Healthcare.Domain.Patients
{
    public interface IPatientAppService
    {
        public Task<PatientUpdate> GetPatientDtoAsync(long id);
        public Task<IEnumerable<PatientQuery>> GetAsync();
        public Task DeleteAsync(long id);
        public Task<long> CreateAsync(PatientCreate patientCreate);
        public Task UpdateAsync(PatientUpdate patientUpdate, long id);
    }
}