using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using apiproyect.Data;
using Microsoft.EntityFrameworkCore;
using library;


namespace apiproyect.Controllers
{
    [ApiController]
    [Route("/api/Empleado")]
    public class EmpleadoController : ControllerBase
    {
        private readonly Datacontext _context;

        public EmpleadoController(Datacontext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Empleados.ToListAsync());


        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var Empleado = await _context.Empleados
                .FirstOrDefaultAsync(x => x.Id == id);
            if (Empleado == null)
            {
                return NotFound("El empleado no fue encontrado");
            }
            return Ok(Empleado);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Empleado empleado)
        {

            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();
            return Ok(empleado);
        }

        [HttpPut]
        public async Task<IActionResult> put(Empleado empleado)
        {

            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();
            return Ok(empleado);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult>  Delete(int id)
        {
            var Fafect = await _context.Empleados
                .Where(x => x.Id == id).ExecuteDeleteAsync();
            if (Fafect==0)
            {
                return NotFound();   
            }
            return NoContent(); 


        }



    }
}
