using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
{
    public void Configure(EntityTypeBuilder<TipoDocumento> builder)
    {
        builder.ToTable("TipoDocumento");
        builder.Property(p => p.Tipdoc_Id).IsRequired();
        builder.Property(p => p.Tipdoc_Name).IsRequired().HasMaxLength(20);
        builder.Property(p => p.Tipdoc_Abbreviation).IsRequired().HasMaxLength(20);
    }
}