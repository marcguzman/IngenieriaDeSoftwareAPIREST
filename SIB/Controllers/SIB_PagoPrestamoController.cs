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
    public class SIB_PagoPrestamoController : ControllerBase
    {
        private readonly SIBContext _context;

        public SIB_PagoPrestamoController(SIBContext context)
        {
            _context = context;
        }

        // GET: api/SIB_PagoPrestamo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SIB_PagoPrestamo>>> GetSIB_PagoPrestamo()
        {
            return await _context.SIB_PagoPrestamo.ToListAsync();
        }

        // GET: api/SIB_PagoPrestamo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SIB_PagoPrestamo>> GetSIB_PagoPrestamo(int id)
        {
            var sIB_PagoPrestamo = await _context.SIB_PagoPrestamo.FindAsync(id);

            if (sIB_PagoPrestamo == null)
            {
                return NotFound();
            }

            return sIB_PagoPrestamo;
        }

        // PUT: api/SIB_PagoPrestamo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSIB_PagoPrestamo(int id, SIB_PagoPrestamo sIB_PagoPrestamo)
        {
            if (id != sIB_PagoPrestamo.Id)
            {
                return BadRequest();
            }

            _context.Entry(sIB_PagoPrestamo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SIB_PagoPrestamoExists(id))
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

        // POST: api/SIB_PagoPrestamo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SIB_PagoPrestamo>> PostSIB_PagoPrestamo(SIB_PagoPrestamo sIB_PagoPrestamo)
        {
            _context.SIB_PagoPrestamo.Add(sIB_PagoPrestamo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSIB_PagoPrestamo", new { id = sIB_PagoPrestamo.Id }, sIB_PagoPrestamo);
        }

        // DELETE: api/SIB_PagoPrestamo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSIB_PagoPrestamo(int id)
        {
            var sIB_PagoPrestamo = await _context.SIB_PagoPrestamo.FindAsync(id);
            if (sIB_PagoPrestamo == null)
            {
                return NotFound();
            }

            _context.SIB_PagoPrestamo.Remove(sIB_PagoPrestamo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SIB_PagoPrestamoExists(int id)
        {
            return _context.SIB_PagoPrestamo.Any(e => e.Id == id);
        }
    }
}
