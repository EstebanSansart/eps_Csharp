using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Cita
{
    [Key]
    public int Cit_Code { get; set; }
    public DateTime Cit_Date { get; set; }
    public int Cit_State { get; set; }
    public int Cit_Doctor { get; set; }
    public int Cit_UserData { get; set; }
    public string ? PhoneNumberUser { get; set; }
    public Usuario ? Usuarios { get; set; }
    public string ? IdEstadoCita { get; set; }
    public EstadoCita ? EstadoCitas { get; set; }
    public string ? FullNameMedico { get; set; }
    public Medico ? Medicos { get; set; }
}