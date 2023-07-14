using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class EstadoCitaConfiguration : IEntityTypeConfiguration<EstadoCita>
{
    public void Configure(EntityTypeBuilder<EstadoCita> builder)
    {
        builder.ToTable("EstadoCita");
        builder.Property(p => p.Estcit_Id).IsRequired();
        builder.Property(p => p.Estcit_Name).IsRequired().HasMaxLength(20);
    }    
}