using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetGuardGT.Api.Data;
using NetGuardGT.Api.Models;

namespace NetGuardGT.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SitiosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SitiosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SitioRed>>> ObtenerTodos()
        {
            return Ok(await _context.SitiosRed.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SitioRed>> ObtenerPorId(int id)
        {
            var sitio = await _context.SitiosRed.FindAsync(id);

            if (sitio == null)
            {
                return NotFound(new
                {
                    mensaje = "Sitio de red no encontrado."
                });
            }

            return Ok(sitio);
        }

        [HttpPost]
        public async Task<ActionResult<SitioRed>> Crear(SitioRed sitio)
        {
            if (string.IsNullOrWhiteSpace(sitio.Nombre))
            {
                return BadRequest(new
                {
                    mensaje = "El nombre del sitio es obligatorio."
                });
            }

            sitio.Id = 0;
            sitio.Activo = true;

            _context.SitiosRed.Add(sitio);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(ObtenerPorId),
                new { id = sitio.Id },
                sitio);
        }
    }
}
