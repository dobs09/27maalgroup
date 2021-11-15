using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _27MaalAPI.Data;
using _27MaalAPI.Models;

namespace _27MaalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EgeMaalController : ControllerBase
    {
        private readonly MålDbContext _context;

        public EgeMaalController(MålDbContext context)
        {
            _context = context;
        }

        // GET: api/EgeMål
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EgeMål>>> GetEgeMål()
        {
            return await _context.EgeMål.ToListAsync();
        }

        // GET: api/EgeMål/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EgeMål>> GetEgeMål(int id)
        {
            var egeMål = await _context.EgeMål.FindAsync(id);

            if (egeMål == null)
            {
                return NotFound();
            }

            return egeMål;
        }

        // PUT: api/EgeMål/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEgeMål(int id, EgeMål egeMål)
        {
            if (id != egeMål.Id)
            {
                return BadRequest();
            }

            _context.Entry(egeMål).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EgeMålExists(id))
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

        // POST: api/EgeMål
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EgeMål>> PostEgeMål(EgeMål egeMål)
        {
            _context.EgeMål.Add(egeMål);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EgeMålExists(egeMål.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEgeMål", new { id = egeMål.Id }, egeMål);
        }

        // DELETE: api/EgeMål/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EgeMål>> DeleteEgeMål(int id)
        {
            var egeMål = await _context.EgeMål.FindAsync(id);
            if (egeMål == null)
            {
                return NotFound();
            }

            _context.EgeMål.Remove(egeMål);
            await _context.SaveChangesAsync();

            return egeMål;
        }

        private bool EgeMålExists(int id)
        {
            return _context.EgeMål.Any(e => e.Id == id);
        }
    }
}
