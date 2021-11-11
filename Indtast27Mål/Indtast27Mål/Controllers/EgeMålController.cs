using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Indtast27Mål.Data;
using Indtast27Mål.Models;

namespace Indtast27Mål.Controllers
{
    public class EgeMålController : Controller
    {
        private readonly MålDbContext _context;

        public EgeMålController(MålDbContext context)
        {
            _context = context;
        }

        // GET: EgeMål
        public async Task<IActionResult> Index()
        {
            return View(await _context.EgeMål.ToListAsync());
        }

        // GET: EgeMål/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var egeMål = await _context.EgeMål
                .FirstOrDefaultAsync(m => m.Id == id);
            if (egeMål == null)
            {
                return NotFound();
            }

            return View(egeMål);
        }

        // GET: EgeMål/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EgeMål/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Kategori,StatusEgedal,StatusDanmark,SenesteEgedal,SenesteDanmark,Placering,Hvad,Hvorfor,Initiativer")] EgeMål egeMål)
        {
            if (ModelState.IsValid)
            {
                _context.Add(egeMål);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(egeMål);
        }

        // GET: EgeMål/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var egeMål = await _context.EgeMål.FindAsync(id);
            if (egeMål == null)
            {
                return NotFound();
            }
            return View(egeMål);
        }

        // POST: EgeMål/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Kategori,StatusEgedal,StatusDanmark,SenesteEgedal,SenesteDanmark,Placering,Hvad,Hvorfor,Initiativer,Indikator")] EgeMål egeMål)
        {
            if (id != egeMål.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(egeMål);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EgeMålExists(egeMål.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(egeMål);
        }

        // GET: EgeMål/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var egeMål = await _context.EgeMål
                .FirstOrDefaultAsync(m => m.Id == id);
            if (egeMål == null)
            {
                return NotFound();
            }

            return View(egeMål);
        }

        // POST: EgeMål/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var egeMål = await _context.EgeMål.FindAsync(id);
            _context.EgeMål.Remove(egeMål);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EgeMålExists(int id)
        {
            return _context.EgeMål.Any(e => e.Id == id);
        }
    }
}
