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
    public class SIB_PagoTCController : ControllerBase
    {
        private readonly SIBContext _context;

        public SIB_PagoTCController(SIBContext context)
        {
            _context = context;
        }

        // GET: api/SIB_PagoTC
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SIB_PagoTC>>> GetSIB_PagoTC()
        {
            return await _context.SIB_PagoTC.ToListAsync();
        }

        // GET: api/SIB_PagoTC/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SIB_PagoTC>> GetSIB_PagoTC(int id)
        {
            var sIB_PagoTC = await _context.SIB_PagoTC.FindAsync(id);

            if (sIB_PagoTC == null)
            {
                return NotFound();
            }

            return sIB_PagoTC;
        }

        // PUT: api/SIB_PagoTC/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSIB_PagoTC(int id, SIB_PagoTC sIB_PagoTC)
        {
            if (id != sIB_PagoTC.Id)
            {
                return BadRequest();
            }

            _context.Entry(sIB_PagoTC).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SIB_PagoTCExists(id))
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

        // POST: api/SIB_PagoTC
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SIB_PagoTC>> PostSIB_PagoTC(SIB_PagoTC sIB_PagoTC)
        {
            _context.SIB_PagoTC.Add(sIB_PagoTC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSIB_PagoTC", new { id = sIB_PagoTC.Id }, sIB_PagoTC);
        }

        // DELETE: api/SIB_PagoTC/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSIB_PagoTC(int id)
        {
            var sIB_PagoTC = await _context.SIB_PagoTC.FindAsync(id);
            if (sIB_PagoTC == null)
            {
                return NotFound();
            }

            _context.SIB_PagoTC.Remove(sIB_PagoTC);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SIB_PagoTCExists(int id)
        {
            return _context.SIB_PagoTC.Any(e => e.Id == id);
        }
    }
}
