using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configutation;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");
        builder.Property(p => p.Usu_Id).IsRequired();
        builder.Property(p => p.Usu_FirstName).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Usu_SecondName).IsRequired().HasMaxLength(45);
        builder.Property(p => p.Usu_Lastname).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Usu_SecondLastname).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Usu_PhoneNumber).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Usu_Address).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Usu_Email).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Usu_Tipodoc).IsRequired();
        builder.Property(p => p.Usu_Gender).IsRequired();
        builder.Property(p => p.Usu_Attendant).IsRequired();

        builder.HasOne(p => p.TipoDocumentos).WithMany(e => e.Usuarios).HasForeignKey(f => f.NameTipoDocumento);
        builder.HasOne(p => p.Generos).WithMany(e => e.Usuarios).HasForeignKey(f => f.NameGenero);
        builder.HasOne(p => p.Acudientes).WithMany(e => e.Usuarios).HasForeignKey(f => f.FullNameAcudiente);
    }
}