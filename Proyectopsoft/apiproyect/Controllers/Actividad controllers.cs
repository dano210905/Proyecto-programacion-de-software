using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using apiproyect.Data;
using Microsoft.EntityFrameworkCore;
using library;


namespace apiproyect.Controllers
{
    [ApiController]
    [Route("/api/Actividad")]
    public class ActividadController : ControllerBase
    {
        private readonly Datacontext _context;

        public ActividadController(Datacontext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Actividades.ToListAsync());


        }   

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var Actividad = await _context.Actividades
                .FirstOrDefaultAsync(x => x.Id == id);
            if (Actividad == null)
            {
                return NotFound("La actividad");
            }
            return Ok(Actividad);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Actividad actividad)
        {

            _context.Actividades.Add(actividad);
            await _context.SaveChangesAsync();
            return Ok(actividad);
        }

        [HttpPut]
        public async Task<IActionResult> put(Actividad actividad)
        {

            _context.Actividades.Add(actividad);
            await _context.SaveChangesAsync();
            return Ok(actividad);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Fafect = await _context.Actividades
                .Where(x => x.Id == id).ExecuteDeleteAsync();
            if (Fafect == 0)
            {
                return NotFound();
            }
            return NoContent();


        }



    }
}
