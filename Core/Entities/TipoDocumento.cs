using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class TipoDocumento
{
    [Key]
    public int Tipdoc_Id { get; set; }
    public string ? Tipdoc_Name { get; set; }
    public string ? Tipdoc_Abbreviation { get; set; }
    public ICollection<Usuario> ? Usuarios { get; set; }
}