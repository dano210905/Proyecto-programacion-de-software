using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using apiproyect.Data;
using Microsoft.EntityFrameworkCore;
using library;


namespace apiproyect.Controllers
{
    [ApiController]
    [Route("/api/EmpleadoActividad")]
    public class EmpleadoactividadController : ControllerBase
    {
        private readonly Datacontext _context;

        public EmpleadoactividadController(Datacontext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var Empleadoactividad = await _context.Empleadoactividades
                .FirstOrDefaultAsync(x => x.Id == id);
            if (Empleadoactividad == null)
            {
                return NotFound("La actividad con el empleado");
            }
            return Ok(Empleadoactividad);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Empleadoactividad empleadoactividad)
        {

            _context.Empleadoactividades.Add(empleadoactividad);
            await _context.SaveChangesAsync();
            return Ok(empleadoactividad);
        }

        [HttpPut]
        public async Task<IActionResult> put(Empleadoactividad empleadoactividad)
        {

            _context.Empleadoactividades.Add(empleadoactividad);
            await _context.SaveChangesAsync();
            return Ok(empleadoactividad);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Fafect = await _context.Empleadoactividades
                .Where(x => x.Id == id).ExecuteDeleteAsync();
            if (Fafect == 0)
            {
                return NotFound();
            }
            return NoContent();


        }



    }
}
