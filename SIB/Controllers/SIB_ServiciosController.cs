using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIB.Data;
using SIB.Models;

namespace SIB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SIB_ServiciosController : ControllerBase
    {
        private readonly SIBContext _context;

        public SIB_ServiciosController(SIBContext context)
        {
            _context = context;
        }

        // GET: api/SIB_Servicios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SIB_Servicios>>> GetSIB_Servicios()
        {
            return await _context.SIB_Servicios.ToListAsync();
        }

        // GET: api/SIB_Servicios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SIB_Servicios>> GetSIB_Servicios(int id)
        {
            var sIB_Servicios = await _context.SIB_Servicios.FindAsync(id);

            if (sIB_Servicios == null)
            {
                return NotFound();
            }

            return sIB_Servicios;
        }

        // PUT: api/SIB_Servicios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSIB_Servicios(int id, SIB_Servicios sIB_Servicios)
        {
            if (id != sIB_Servicios.Id)
            {
                return BadRequest();
            }

            _context.Entry(sIB_Servicios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SIB_ServiciosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SIB_Servicios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SIB_Servicios>> PostSIB_Servicios(SIB_Servicios sIB_Servicios)
        {
            _context.SIB_Servicios.Add(sIB_Servicios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSIB_Servicios", new { id = sIB_Servicios.Id }, sIB_Servicios);
        }

        // DELETE: api/SIB_Servicios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSIB_Servicios(int id)
        {
            var sIB_Servicios = await _context.SIB_Servicios.FindAsync(id);
            if (sIB_Servicios == null)
            {
                return NotFound();
            }

            _context.SIB_Servicios.Remove(sIB_Servicios);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SIB_ServiciosExists(int id)
        {
            return _context.SIB_Servicios.Any(e => e.Id == id);
        }
    }
}
