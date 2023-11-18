using Healthcare.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Healthcare.Data.Configurations;

internal abstract class AuditConfig<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Audit
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.CreatedIn)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired()
                .ValueGeneratedOnAdd();

        builder.Property(x => x.UpdatedIn)
                .HasDefaultValue(null);

        builder.Property(x => x.DeletedIn)
                .IsRequired(false)
                .HasDefaultValue(null);
    }
}
