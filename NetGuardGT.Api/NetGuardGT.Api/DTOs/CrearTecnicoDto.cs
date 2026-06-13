using System.ComponentModel.DataAnnotations;
using NetGuardGT.Api.Enums;

namespace NetGuardGT.Api.DTOs
{
    public class CrearTecnicoDto
    {
        [Required]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Correo { get; set; } = string.Empty;

        [Required]
        public string Telefono { get; set; } = string.Empty;

        [Required]
        public List<EspecialidadTecnica> Especialidades { get; set; } = new();
    }
}
