using Healthcare.Domain.Dtos;
using Healthcare.Domain.Patients;
using Microsoft.EntityFrameworkCore;

namespace Healthcare.Data;

public sealed class PatientRepository : 
    RepositoryBase<Patient>, 
    IPatientRepository
{
    public PatientRepository(AppDbContext dbContext) : base(dbContext)
    { }

    public async Task<IEnumerable<PatientQuery>> GetAsync()
    {
        var list = _dbContext.Patients.Select(patient => (PatientQuery)patient);
        return await Task.FromResult(list ?? Enumerable.Empty<PatientQuery>());
    }

    public async Task DeleteAsyn(long id)
    {
        FormattableString delete = $"DELETE FROM Patients WHERE Id = {id}";
        await _dbContext.Database.ExecuteSqlAsync(delete);
    }
}
