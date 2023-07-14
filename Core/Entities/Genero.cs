using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Genero
{
    [Key]
    public int Gen_Id { get; set; }
    public string ? Gen_Name { get; set; }
    public string ? Gen_Abbreviation { get; set; }
    public ICollection<Usuario> ? Usuarios { get; set; }
}