using Healthcare.Domain.Patients;

namespace Healthcare.Data;

public sealed class PatientRepository : RepositoryBase<Patient>, IPatientRepository
{
    public PatientRepository(AppDbContext dbContext) : base(dbContext)
    { }
}
