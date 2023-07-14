using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Especialidad
{
    [Key]
    public int Esp_Id { get; set; }
    public string ? Esp_Name { get; set; }
    public ICollection<Medico> ? Medicos { get; set; }
}