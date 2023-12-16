using Healthcare.Domain.Dtos;
using Healthcare.Domain.Patients;

namespace Healthcare.AppService
{
    public class PatientAppService : IPatientAppService
    {
        private readonly IPatientRepository _repository;

        public PatientAppService(IPatientRepository repository)
            => _repository = repository;

        public async Task<PatientDto> GetPatientDtoAsync(long id)
        {
            var patient = await _repository.FindByIdAsync( id, CancellationToken.None);
            return patient;
        }
    }
}

