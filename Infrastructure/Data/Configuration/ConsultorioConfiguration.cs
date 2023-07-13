using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ConsultorioConfiguration : IEntityTypeConfiguration<Consultorio>
{
    public void Configure(EntityTypeBuilder<Consultorio> builder)
    {
        builder.ToTable("Consultorio");
        builder.Property(p => p.Cons_Code).IsRequired();
        builder.Property(p => p.Cons_Name).IsRequired().HasMaxLength(50);
    }
}