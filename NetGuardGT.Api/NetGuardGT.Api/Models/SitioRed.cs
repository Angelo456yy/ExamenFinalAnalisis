using System.ComponentModel.DataAnnotations;
using NetGuardGT.Api.Enums;

namespace NetGuardGT.Api.Models;

public class SitioRed
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [MaxLength(150)]
    public string Ubicacion { get; set; } = string.Empty;

    public TipoSitioRed Tipo { get; set; }

    public bool Activo { get; set; } = true;

    public ICollection<Incidente> Incidentes { get; set; } = new List<Incidente>();
}
