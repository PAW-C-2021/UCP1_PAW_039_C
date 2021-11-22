using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UCP1_PAW_039_C.Models;

namespace UCP1_PAW_039_C.Controllers
{
    public class MaterisController : Controller
    {
        private readonly ClassFunContext _context;

        public MaterisController(ClassFunContext context)
        {
            _context = context;
        }

        // GET: Materis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Materis.ToListAsync());
        }

        // GET: Materis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materi = await _context.Materis
                .FirstOrDefaultAsync(m => m.IdMateri == id);
            if (materi == null)
            {
                return NotFound();
            }

            return View(materi);
        }

        // GET: Materis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Materis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMateri,Materi1,Serach,UrlMateri,UrlVideo,UrlPicture")] Materi materi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(materi);
        }

        // GET: Materis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materi = await _context.Materis.FindAsync(id);
            if (materi == null)
            {
                return NotFound();
            }
            return View(materi);
        }

        // POST: Materis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMateri,Materi1,Serach,UrlMateri,UrlVideo,UrlPicture")] Materi materi)
        {
            if (id != materi.IdMateri)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MateriExists(materi.IdMateri))
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
            return View(materi);
        }

        // GET: Materis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materi = await _context.Materis
                .FirstOrDefaultAsync(m => m.IdMateri == id);
            if (materi == null)
            {
                return NotFound();
            }

            return View(materi);
        }

        // POST: Materis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materi = await _context.Materis.FindAsync(id);
            _context.Materis.Remove(materi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MateriExists(int id)
        {
            return _context.Materis.Any(e => e.IdMateri == id);
        }
    }
}
