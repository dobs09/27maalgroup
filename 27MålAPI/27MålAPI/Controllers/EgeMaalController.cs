using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _27MålAPI.Data;
using _27MålAPI.Models;

namespace _27MålAPI.Controllers
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
        public async Task<ActionResult<IEnumerable<EgeMaal>>> GetEgeMaal()
        {
            return await _context.EgeMaal.ToListAsync();
        }

        // GET: api/EgeMål/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EgeMaal>> GetEgeMaal(int id)
        {
            var egeMaal = await _context.EgeMaal.FindAsync(id);

            if (egeMaal == null)
            {
                return NotFound();
            }

            return egeMaal;
        }

        // PUT: api/EgeMål/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEgeMål(int id, EgeMaal egeMaal)
        {
            if (id != egeMaal.Id)
            {
                return BadRequest();
            }

            _context.Entry(egeMaal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EgeMaalExists(id))
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
        public async Task<ActionResult<EgeMaal>> PostEgeMaal(EgeMaal egeMaal)
        {
            _context.EgeMaal.Add(egeMaal);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EgeMaalExists(egeMaal.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEgeMaal", new { id = egeMaal.Id }, egeMaal);
        }

        // DELETE: api/EgeMål/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EgeMaal>> DeleteEgeMaal(int id)
        {
            var egeMaal = await _context.EgeMaal.FindAsync(id);
            if (egeMaal == null)
            {
                return NotFound();
            }

            _context.EgeMaal.Remove(egeMaal);
            await _context.SaveChangesAsync();

            return egeMaal;
        }

        private bool EgeMaalExists(int id)
        {
            return _context.EgeMaal.Any(e => e.Id == id);
        }
    }
}
