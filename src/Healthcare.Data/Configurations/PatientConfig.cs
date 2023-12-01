using Healthcare.Domain.Patients;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Healthcare.Data.Configurations;

internal sealed class PatientConfig: AuditConfig<Patient>
{
    public override void Configure(EntityTypeBuilder<Patient> builder)
    {
        base.Configure(builder);
        
        builder.Property(x => x.FirstName)
               .IsRequired();

        builder.Property(x => x.LastName)
               .IsRequired();

        builder.Property(x => x.Gender)
               .IsRequired();

        builder.OwnsOne(x => x.Address, ad => 
        {
            ad.Property(x => x.ZipCode)
              .IsRequired();

            ad.Property(x => x.UF)
              .IsRequired();

            ad.Property(x => x.City)
              .IsRequired();
            
            ad.Property(x => x.District)
              .IsRequired();              
        });

        builder.Ignore(x => x.Name);
        builder.Ignore(x => x.IsActive);
    }
}
