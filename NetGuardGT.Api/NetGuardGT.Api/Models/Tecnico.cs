using System.ComponentModel.DataAnnotations;

namespace NetGuardGT.Api.Models;

public class Tecnico
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string NombreCompleto { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [MaxLength(120)]
    public string Correo { get; set; } = string.Empty;

    [Required]
    [MaxLength(20)]
    public string Telefono { get; set; } = string.Empty;

    public bool Activo { get; set; } = true;

    public ICollection<TecnicoEspecialidad> Especialidades { get; set; }
        = new List<TecnicoEspecialidad>();

    public ICollection<Incidente> IncidentesAsignados { get; set; }
        = new List<Incidente>();
}
