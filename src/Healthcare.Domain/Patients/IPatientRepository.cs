
using Healthcare.Domain.Dtos;

namespace Healthcare.Domain.Patients;
public interface IPatientRepository : IRepository<Patient>
{
    public Task<IEnumerable<PatientQuery>> GetAsync();
    public Task DeleteAsync(long id);
}