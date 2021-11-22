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
    public class EditProfilsController : Controller
    {
        private readonly ClassFunContext _context;

        public EditProfilsController(ClassFunContext context)
        {
            _context = context;
        }

        // GET: EditProfils
        public async Task<IActionResult> Index()
        {
            return View(await _context.EditProfils.ToListAsync());
        }

        // GET: EditProfils/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editProfil = await _context.EditProfils
                .FirstOrDefaultAsync(m => m.IdEditProfil == id);
            if (editProfil == null)
            {
                return NotFound();
            }

            return View(editProfil);
        }

        // GET: EditProfils/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EditProfils/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEditProfil,Username,Name,PhoneNumber,Addres")] EditProfil editProfil)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editProfil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(editProfil);
        }

        // GET: EditProfils/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editProfil = await _context.EditProfils.FindAsync(id);
            if (editProfil == null)
            {
                return NotFound();
            }
            return View(editProfil);
        }

        // POST: EditProfils/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEditProfil,Username,Name,PhoneNumber,Addres")] EditProfil editProfil)
        {
            if (id != editProfil.IdEditProfil)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editProfil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditProfilExists(editProfil.IdEditProfil))
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
            return View(editProfil);
        }

        // GET: EditProfils/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editProfil = await _context.EditProfils
                .FirstOrDefaultAsync(m => m.IdEditProfil == id);
            if (editProfil == null)
            {
                return NotFound();
            }

            return View(editProfil);
        }

        // POST: EditProfils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var editProfil = await _context.EditProfils.FindAsync(id);
            _context.EditProfils.Remove(editProfil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditProfilExists(int id)
        {
            return _context.EditProfils.Any(e => e.IdEditProfil == id);
        }
    }
}
