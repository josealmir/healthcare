using Healthcare.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Healthcare.Data.Configurations;

internal sealed class PatientConfig: AuditConfig<Patient>
{
    public override void Configure(EntityTypeBuilder<Patient> builder)
    {
        base.Configure(builder);
    }
}
