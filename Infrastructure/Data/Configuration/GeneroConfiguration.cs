using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.ToTable("Genero");
        builder.Property(p => p.Gen_Id).IsRequired();
        builder.Property(p => p.Gen_Name).IsRequired().HasMaxLength(20);
        builder.Property(p => p.Gen_Abbreviation).IsRequired().HasMaxLength(20);
    }
}