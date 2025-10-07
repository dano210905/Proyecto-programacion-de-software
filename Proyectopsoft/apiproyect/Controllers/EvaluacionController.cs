using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using apiproyect.Data;
using Microsoft.EntityFrameworkCore;
using library;


namespace apiproyect.Controllers
{
    [ApiController]
    [Route("/api/Evaluacion")]
    public class EvaluacionController : ControllerBase
    {
        private readonly Datacontext _context;

        public EvaluacionController(Datacontext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Evaluaciones.ToListAsync());


        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var Evaluacion = await _context.Evaluaciones
                .FirstOrDefaultAsync(x => x.Id == id);
            if (Evaluacion == null)
            {
                return NotFound("La evaluacion");
            }
            return Ok(Evaluacion);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Evaluacion evaluacion)
        {

            _context.Evaluaciones.Add(evaluacion);
            await _context.SaveChangesAsync();
            return Ok(evaluacion);
        }

        [HttpPut]
        public async Task<IActionResult> put(Evaluacion evaluacion)
        {

            _context.Evaluaciones.Add(evaluacion);
            await _context.SaveChangesAsync();
            return Ok(evaluacion);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Fafect = await _context.Evaluaciones
                .Where(x => x.Id == id).ExecuteDeleteAsync();
            if (Fafect == 0)
            {
                return NotFound();
            }
            return NoContent();


        }



    }
}
