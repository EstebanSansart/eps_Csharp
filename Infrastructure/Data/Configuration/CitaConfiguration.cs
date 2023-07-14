using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class CitaConfiguration : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
        builder.ToTable("Cita");
        builder.Property(p => p.Cit_Code).IsRequired();
        builder.Property(p => p.Cit_Date).IsRequired().HasColumnType("Date");
        builder.Property(p => p.Cit_State).IsRequired();
        builder.Property(p => p.Cit_Doctor).IsRequired();
        builder.Property(p => p.Cit_UserData).IsRequired();

        builder.HasOne(p => p.Usuarios).WithMany(e => e.Citas).HasForeignKey(f => f.PhoneNumberUser);
        builder.HasOne(p => p.EstadoCitas).WithMany(e => e.Citas).HasForeignKey(f => f.IdEstadoCita);
        builder.HasOne(p => p.Medicos).WithMany(e => e.Citas).HasForeignKey(f => f.FullNameMedico);
    }
}