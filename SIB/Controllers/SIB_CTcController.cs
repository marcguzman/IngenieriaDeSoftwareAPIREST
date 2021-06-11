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
    public class SIB_CTcController : ControllerBase
    {
        private readonly SIBContext _context;

        public SIB_CTcController(SIBContext context)
        {
            _context = context;
        }

        // GET: api/SIB_CTc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SIB_CTc>>> GetSIB_CTc()
        {
            return await _context.SIB_CTc.ToListAsync();
        }

        // GET: api/SIB_CTc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SIB_CTc>> GetSIB_CTc(int id)
        {
            var sIB_CTc = await _context.SIB_CTc.FindAsync(id);

            if (sIB_CTc == null)
            {
                return NotFound();
            }

            return sIB_CTc;
        }

        // PUT: api/SIB_CTc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSIB_CTc(int id, SIB_CTc sIB_CTc)
        {
            if (id != sIB_CTc.Id)
            {
                return BadRequest();
            }

            _context.Entry(sIB_CTc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SIB_CTcExists(id))
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

        // POST: api/SIB_CTc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SIB_CTc>> PostSIB_CTc(SIB_CTc sIB_CTc)
        {
            _context.SIB_CTc.Add(sIB_CTc);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSIB_CTc", new { id = sIB_CTc.Id }, sIB_CTc);
        }

        // DELETE: api/SIB_CTc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSIB_CTc(int id)
        {
            var sIB_CTc = await _context.SIB_CTc.FindAsync(id);
            if (sIB_CTc == null)
            {
                return NotFound();
            }

            _context.SIB_CTc.Remove(sIB_CTc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SIB_CTcExists(int id)
        {
            return _context.SIB_CTc.Any(e => e.Id == id);
        }
    }
}
