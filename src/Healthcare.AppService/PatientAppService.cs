using Healthcare.Domain.Dtos;
using Healthcare.Domain.Infra;
using Healthcare.Domain.Patients;

namespace Healthcare.AppService
{
    public class PatientAppService : IPatientAppService
    {
        private readonly IPatientRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        
        public PatientAppService(
            IUnitOfWork unitOfWork,
            IPatientRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<long> CreateAsync(PatientCreate patientCreate)
        {
            Patient patient = patientCreate;
            _repository.Add(patient);
            await _unitOfWork.SaveChangeAsync();
            return patient.Id;
        }

        public async Task DeleteAsync(long id)
        {
            await _repository.DeleteAsync(id);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<PatientQuery>> GetAsync()
            => await _repository.GetAsync();

        public async Task<PatientDto> GetPatientDtoAsync(long id)
        {
            var patient = await _repository.FindByIdAsync( id, CancellationToken.None);
            return patient;
        }
    }
}

