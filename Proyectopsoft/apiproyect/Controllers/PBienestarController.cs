using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using apiproyect.Data;
using Microsoft.EntityFrameworkCore;
using library;


namespace apiproyect.Controllers
{
    [ApiController]
    [Route("/api/Bienestar")]
    public class PBienestarController : ControllerBase
    {
        private readonly Datacontext _context;

        public PBienestarController(Datacontext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var pBienestar = await _context.PBienestars
                .FirstOrDefaultAsync(x => x.Id == id);
            if (pBienestar == null)
            {
                return NotFound("El programa de bienestar no fue encontrado");
            }
            return Ok(pBienestar);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PBienestar pbienestar)
        {

            _context.PBienestars.Add(pbienestar);
            await _context.SaveChangesAsync();
            return Ok(pbienestar);
        }

        [HttpPut]
        public async Task<IActionResult> put(PBienestar pbienestar)
        {

            _context.PBienestars.Add(pbienestar);
            await _context.SaveChangesAsync();
            return Ok(pbienestar);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Fafect = await _context.PBienestars
                .Where(x => x.Id == id).ExecuteDeleteAsync();
            if (Fafect == 0)
            {
                return NotFound();
            }
            return NoContent();


        }



    }
}
