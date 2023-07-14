using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Usuario
{
    [Key]
    public int Usu_Id { get; set; }
    public string ? Usu_FirstName { get; set; }
    public string ? Usu_SecondName { get; set; }
    public string ? Usu_Lastname { get; set; }
    public string ? Usu_SecondLastname { get; set; }
    public string ? Usu_PhoneNumber { get; set; }
    public string ? Usu_Address { get; set; }
    public string ? Usu_Email { get; set; }
    public int Usu_Tipodoc { get; set; }
    public int Usu_Gender { get; set; }
    public int Usu_Attendant { get; set; }
    public ICollection<Cita> ? Citas { get; set ; } 
    public string ? NameTipoDocumento { get; set; }
    public TipoDocumento ? TipoDocumentos { get; set; }
    public string ? NameGenero { get; set; }
    public Genero ? Generos { get; set; }
    public string ? FullNameAcudiente { get; set; }
    public Acudiente ? Acudientes { get; set; }
}