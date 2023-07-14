using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class EstadoCita
{
    [Key]
    public int Estcit_Id { get; set; }
    public string ? Estcit_Name { get; set; }
    public ICollection<Cita> ? Citas { get; set; }
}