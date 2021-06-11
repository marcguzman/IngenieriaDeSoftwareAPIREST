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
    public class SIB_TransferenciasController : ControllerBase
    {
        private readonly SIBContext _context;

        public SIB_TransferenciasController(SIBContext context)
        {
            _context = context;
        }

        // GET: api/SIB_Transferencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SIB_Transferencias>>> GetSIB_Transferencias()
        {
            return await _context.SIB_Transferencias.ToListAsync();
        }

        // GET: api/SIB_Transferencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SIB_Transferencias>> GetSIB_Transferencias(int id)
        {
            var sIB_Transferencias = await _context.SIB_Transferencias.FindAsync(id);

            if (sIB_Transferencias == null)
            {
                return NotFound();
            }

            return sIB_Transferencias;
        }

        // PUT: api/SIB_Transferencias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSIB_Transferencias(int id, SIB_Transferencias sIB_Transferencias)
        {
            if (id != sIB_Transferencias.Id)
            {
                return BadRequest();
            }

            _context.Entry(sIB_Transferencias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SIB_TransferenciasExists(id))
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

        // POST: api/SIB_Transferencias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SIB_Transferencias>> PostSIB_Transferencias(SIB_Transferencias sIB_Transferencias)
        {
            _context.SIB_Transferencias.Add(sIB_Transferencias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSIB_Transferencias", new { id = sIB_Transferencias.Id }, sIB_Transferencias);
        }

        // DELETE: api/SIB_Transferencias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSIB_Transferencias(int id)
        {
            var sIB_Transferencias = await _context.SIB_Transferencias.FindAsync(id);
            if (sIB_Transferencias == null)
            {
                return NotFound();
            }

            _context.SIB_Transferencias.Remove(sIB_Transferencias);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SIB_TransferenciasExists(int id)
        {
            return _context.SIB_Transferencias.Any(e => e.Id == id);
        }
    }
}
