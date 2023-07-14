using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class miEpsContext : DbContext{
    public miEpsContext(DbContextOptions<miEpsContext> options) : base(options){

    }
    public DbSet<Acudiente> ? Acudiente { get; set; }
    public DbSet<Cita> ? Cita { get; set; }
    public DbSet<Consultorio> ? Consultorio { get; set; }
    public DbSet<Especialidad> ? Especialidad { get; set; }
    public DbSet<EstadoCita> ? EstadoCita { get; set; }
    public DbSet<Genero> ? Genero { get; set; }
    public DbSet<Medico> ? Medico { get; set; }
    public DbSet<TipoDocumento> ? TipoDocumento { get; set; }
    public DbSet<Usuario>? Usuario { get; set; }
}