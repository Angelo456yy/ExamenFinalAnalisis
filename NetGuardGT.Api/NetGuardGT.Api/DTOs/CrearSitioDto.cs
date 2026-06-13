using System.ComponentModel.DataAnnotations;
using NetGuardGT.Api.Enums;

namespace NetGuardGT.Api.DTOs
{
    public class CrearSitioDto
    {
        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Ubicacion { get; set; } = string.Empty;

        public TipoSitioRed Tipo { get; set; }
    }
}
