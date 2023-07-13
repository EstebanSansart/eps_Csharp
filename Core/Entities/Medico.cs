using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Medico
{
    [Key]
    public int Med_PersonalRegistrationNumber { get; set; }
    public string ? Med_FullName { get; set; }
    public int Med_Office { get; set; }
    public int Med_Specialty { get; set; }
    public ICollection<Cita> ? Citas { get; set; }
    public string ? IdEspecialidad { get; set; }
    public Especialidad ? Especialidades { get; set; }
    public string ? IdConsultorio { get; set; }
    public Consultorio ? Consultorios { get; set; }
}