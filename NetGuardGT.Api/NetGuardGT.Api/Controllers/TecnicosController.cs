using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetGuardGT.Api.Data;
using NetGuardGT.Api.Enums;
using NetGuardGT.Api.Models;

namespace NetGuardGT.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TecnicosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TecnicosController(AppDbContext context)
        {
            _context = context;
 








       }

        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var tecnicos = await _context.Tecnicos
                .Include(t => t.Especialidades)
                .Select(t => new
                {
                    t.Id,
                    t.NombreCompleto,
                    t.Correo,
                    t.Telefono,
                    t.Activo,
                    Especialidades = t.Especialidades
    














                    .Select(e => e.Especialidad)
                        .ToList()
                })
                .ToListAsync();

            return Ok(tecnicos);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(
            string nombreCompleto,
 










           string correo,
            string telefono,
            EspecialidadTecnica especialidad)
        {
            correo = correo.Trim().ToLower();

            if (await _context.Tecnicos.AnyAsync(t => t.Correo == correo))
                return BadRequest(new {






 mensaje = "El correo ya está registrado." });

            var tecnico = new Tecnico
            {
                NombreCompleto = nombreCompleto.Trim(),
                Correo = correo,
 





               Telefono = telefono.Trim(),
                Activo = true
            };

            tecnico.Especialidades.Add(new TecnicoEspecialidad
            {
 





               Especialidad = especialidad
            });

            _context.Tecnicos.Add(tecnico);
            await _context.SaveChangesAsync();






            return Ok(new
            {
                mensaje = "Técnico registrado correctamente.",
                tecnico.Id
 




           });
        }
    }
}
