using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configutation;

public class EspecialidadConfiguration : IEntityTypeConfiguration<Especialidad>
{
    public void Configure(EntityTypeBuilder<Especialidad> builder)
    {
        builder.ToTable("Especialidad");
        builder.Property(p => p.Esp_Id).IsRequired();
        builder.Property(p => p.Esp_Name).IsRequired().HasMaxLength(20);
    }
}