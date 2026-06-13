using System.ComponentModel.DataAnnotations;
using NetGuardGT.Api.Enums;

namespace NetGuardGT.Api.Models;

public class Incidente
{
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    public string Titulo { get; set; } = string.Empty;

    [Required]
    [MaxLength(1000)]
    public string Descripcion { get; set; } = string.Empty;

    public TipoIncidente Tipo { get; set; }

    public SeveridadIncidente Severidad { get; set; }

    public EstadoIncidente Estado { get; set; } = EstadoIncidente.Registrado;

    public int SitioRedId { get; set; }

    public SitioRed? SitioRed { get; set; }

    public int? TecnicoAsignadoId { get; set; }

    public Tecnico? TecnicoAsignado { get; set; }

    public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

    public DateTime FechaLimiteSla { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaResolucion { get; set; }

    public DateTime? FechaCierre { get; set; }

    [MaxLength(1000)]
    public string? SolucionAplicada { get; set; }

    public bool Escalado { get; set; }

    public DateTime? FechaEscalamiento { get; set; }

    public ICollection<HistorialIncidente> Historial { get; set; }
        = new List<HistorialIncidente>();
}
