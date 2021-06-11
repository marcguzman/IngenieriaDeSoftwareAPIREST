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
    public class SIB_CcuentaController : ControllerBase
    {
        private readonly SIBContext _context;

        public SIB_CcuentaController(SIBContext context)
        {
            _context = context;
        }

        // GET: api/SIB_Ccuenta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SIB_Ccuenta>>> GetSIB_Ccuenta()
        {
            return await _context.SIB_Ccuenta.ToListAsync();
        }

        // GET: api/SIB_Ccuenta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SIB_Ccuenta>> GetSIB_Ccuenta(int id)
        {
            var sIB_Ccuenta = await _context.SIB_Ccuenta.FindAsync(id);

            if (sIB_Ccuenta == null)
            {
                return NotFound();
            }

            return sIB_Ccuenta;
        }

        // PUT: api/SIB_Ccuenta/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSIB_Ccuenta(int id, SIB_Ccuenta sIB_Ccuenta)
        {
            if (id != sIB_Ccuenta.Id)
            {
                return BadRequest();
            }

            _context.Entry(sIB_Ccuenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SIB_CcuentaExists(id))
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

        // POST: api/SIB_Ccuenta
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SIB_Ccuenta>> PostSIB_Ccuenta(SIB_Ccuenta sIB_Ccuenta)
        {
            _context.SIB_Ccuenta.Add(sIB_Ccuenta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSIB_Ccuenta", new { id = sIB_Ccuenta.Id }, sIB_Ccuenta);
        }

        // DELETE: api/SIB_Ccuenta/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSIB_Ccuenta(int id)
        {
            var sIB_Ccuenta = await _context.SIB_Ccuenta.FindAsync(id);
            if (sIB_Ccuenta == null)
            {
                return NotFound();
            }

            _context.SIB_Ccuenta.Remove(sIB_Ccuenta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SIB_CcuentaExists(int id)
        {
            return _context.SIB_Ccuenta.Any(e => e.Id == id);
        }
    }
}
