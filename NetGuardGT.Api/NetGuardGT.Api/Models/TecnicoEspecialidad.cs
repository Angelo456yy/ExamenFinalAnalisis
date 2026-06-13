using NetGuardGT.Api.Enums;

namespace NetGuardGT.Api.Models;

public class TecnicoEspecialidad
{
    public int TecnicoId { get; set; }

    public Tecnico? Tecnico { get; set; }

    public EspecialidadTecnica Especialidad { get; set; }
}
