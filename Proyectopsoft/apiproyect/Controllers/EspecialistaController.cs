using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using apiproyect.Data;
using Microsoft.EntityFrameworkCore;
using library;


namespace apiproyect.Controllers
{
    [ApiController]
    [Route("/api/Especialista")]
    public class EspecialistaController : ControllerBase
    {
        private readonly Datacontext _context;

        public EspecialistaController(Datacontext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var Especialista = await _context.Empleados
                .FirstOrDefaultAsync(x => x.Id == id);
            if (Especialista == null)
            {
                return NotFound("El empleado no fue encontrado");
            }
            return Ok(Especialista);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Especialista especialista)
        {

            _context.Especialistas.Add(especialista);
            await _context.SaveChangesAsync();
            return Ok(especialista);
        }

        [HttpPut]
        public async Task<IActionResult> put(Especialista especialista)
        {

            _context.Especialistas.Add(especialista);
            await _context.SaveChangesAsync();
            return Ok(especialista);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Fafect = await _context.Especialistas
                .Where(x => x.Id == id).ExecuteDeleteAsync();
            if (Fafect == 0)
            {
                return NotFound();
            }
            return NoContent();


        }



    }
}
