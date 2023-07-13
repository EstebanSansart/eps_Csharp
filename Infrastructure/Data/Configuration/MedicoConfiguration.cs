using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.ToTable("Medico");
        builder.Property(p => p.Med_PersonalRegistrationNumber).IsRequired();
        builder.Property(p => p.Med_FullName).IsRequired().HasMaxLength(120);
        builder.Property(p => p.Med_Office).IsRequired();
        builder.Property(p => p.Med_Specialty).IsRequired();

        builder.HasOne(p => p.Especialidades).WithMany(e => e.Medicos).HasForeignKey(f => f.IdEspecialidad);
        builder.HasOne(p => p.Consultorios).WithMany(e => e.Medicos).HasForeignKey(f => f.IdConsultorio);
    }

}