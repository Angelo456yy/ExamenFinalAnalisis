using System.ComponentModel.DataAnnotations;
using NetGuardGT.Api.Enums;

namespace NetGuardGT.Api.Models;

public class HistorialIncidente
{
    public int Id { get; set; }

    public int IncidenteId { get; set; }

    public Incidente? Incidente { get; set; }

    public EstadoIncidente? EstadoAnterior { get; set; }

    public EstadoIncidente EstadoNuevo { get; set; }

    [Required]
    [MaxLength(100)]
    public string Accion { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Detalle { get; set; }

    [Required]
    [MaxLength(100)]
    public string Responsable { get; set; } = string.Empty;

    public DateTime FechaCambio { get; set; } = DateTime.UtcNow;
}
