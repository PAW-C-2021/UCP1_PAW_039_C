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
    public class UpgradesController : Controller
    {
        private readonly ClassFunContext _context;

        public UpgradesController(ClassFunContext context)
        {
            _context = context;
        }

        // GET: Upgrades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Upgrades.ToListAsync());
        }

        // GET: Upgrades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upgrade = await _context.Upgrades
                .FirstOrDefaultAsync(m => m.IdUpgrade == id);
            if (upgrade == null)
            {
                return NotFound();
            }

            return View(upgrade);
        }

        // GET: Upgrades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Upgrades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUpgrade,TrialMode,PremiumMode")] Upgrade upgrade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(upgrade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(upgrade);
        }

        // GET: Upgrades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upgrade = await _context.Upgrades.FindAsync(id);
            if (upgrade == null)
            {
                return NotFound();
            }
            return View(upgrade);
        }

        // POST: Upgrades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUpgrade,TrialMode,PremiumMode")] Upgrade upgrade)
        {
            if (id != upgrade.IdUpgrade)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(upgrade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UpgradeExists(upgrade.IdUpgrade))
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
            return View(upgrade);
        }

        // GET: Upgrades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upgrade = await _context.Upgrades
                .FirstOrDefaultAsync(m => m.IdUpgrade == id);
            if (upgrade == null)
            {
                return NotFound();
            }

            return View(upgrade);
        }

        // POST: Upgrades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var upgrade = await _context.Upgrades.FindAsync(id);
            _context.Upgrades.Remove(upgrade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UpgradeExists(int id)
        {
            return _context.Upgrades.Any(e => e.IdUpgrade == id);
        }
    }
}
