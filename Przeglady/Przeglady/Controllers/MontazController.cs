using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Przeglady.Data;
using Przeglady.Models;

namespace Przeglady.Controllers
{

    [Authorize]
    public class MontazController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MontazController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Montaz
        public async Task<IActionResult> Index()
        {
            return View(await _context.Montaz.ToListAsync());
        }

        // GET: Montaz/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var montaz = await _context.Montaz
                .FirstOrDefaultAsync(m => m.Id == id);
            if (montaz == null)
            {
                return NotFound();
            }

            return View(montaz);
        }

        // GET: Montaz/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Montaz/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nazwa,Imie,Nazwisko,Telefon,Email,Nip,Zaproszenie,Gwarancja,DataMontazu,DataOstatniegoPrzegladu,Podreczniki,ODOIA,SIGMA,Uwagi")] Montaz montaz)
        {
          
            if (ModelState.IsValid)
            {
                _context.Add(montaz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(montaz);
        }

        // GET: Montaz/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var montaz = await _context.Montaz.FindAsync(id);
            if (montaz == null)
            {
                return NotFound();
            }
            return View(montaz);
        }

        // POST: Montaz/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nazwa,Imie,Nazwisko,Telefon,Email,Nip,Zaproszenie,Gwarancja,DataMontazu,DataOstatniegoPrzegladu,Podreczniki,ODOIA,SIGMA,Uwagi")] Montaz montaz)
        {
            if (id != montaz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(montaz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MontazExists(montaz.Id))
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
            return View(montaz);
        }

        [Authorize(Policy = "Administrator")]
        // GET: Montaz/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var montaz = await _context.Montaz
                .FirstOrDefaultAsync(m => m.Id == id);
            if (montaz == null)
            {
                return NotFound();
            }

            return View(montaz);
        }

        [Authorize(Policy = "Administrator")]
        // POST: Montaz/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var montaz = await _context.Montaz.FindAsync(id);
            _context.Montaz.Remove(montaz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MontazExists(int id)
        {
            return _context.Montaz.Any(e => e.Id == id);
        }


    }
}
