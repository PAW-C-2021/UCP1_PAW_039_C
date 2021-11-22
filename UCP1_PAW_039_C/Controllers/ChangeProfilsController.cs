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
    public class ChangeProfilsController : Controller
    {
        private readonly ClassFunContext _context;

        public ChangeProfilsController(ClassFunContext context)
        {
            _context = context;
        }

        // GET: ChangeProfils
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChangeProfils.ToListAsync());
        }

        // GET: ChangeProfils/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var changeProfil = await _context.ChangeProfils
                .FirstOrDefaultAsync(m => m.IdChangeProfil == id);
            if (changeProfil == null)
            {
                return NotFound();
            }

            return View(changeProfil);
        }

        // GET: ChangeProfils/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChangeProfils/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdChangeProfil,FirstName,LastName,DateofBirth,PhoneNumber,Addres")] ChangeProfil changeProfil)
        {
            if (ModelState.IsValid)
            {
                _context.Add(changeProfil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(changeProfil);
        }

        // GET: ChangeProfils/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var changeProfil = await _context.ChangeProfils.FindAsync(id);
            if (changeProfil == null)
            {
                return NotFound();
            }
            return View(changeProfil);
        }

        // POST: ChangeProfils/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdChangeProfil,FirstName,LastName,DateofBirth,PhoneNumber,Addres")] ChangeProfil changeProfil)
        {
            if (id != changeProfil.IdChangeProfil)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(changeProfil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChangeProfilExists(changeProfil.IdChangeProfil))
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
            return View(changeProfil);
        }

        // GET: ChangeProfils/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var changeProfil = await _context.ChangeProfils
                .FirstOrDefaultAsync(m => m.IdChangeProfil == id);
            if (changeProfil == null)
            {
                return NotFound();
            }

            return View(changeProfil);
        }

        // POST: ChangeProfils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var changeProfil = await _context.ChangeProfils.FindAsync(id);
            _context.ChangeProfils.Remove(changeProfil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChangeProfilExists(int id)
        {
            return _context.ChangeProfils.Any(e => e.IdChangeProfil == id);
        }
    }
}
