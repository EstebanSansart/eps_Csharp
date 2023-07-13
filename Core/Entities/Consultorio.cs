using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Consultorio
{
    [Key]
    public int Cons_Code { get; set; }
    public string ? Cons_Name { get; set; }
    public ICollection<Medico> ? Medicos { get; set; }
}