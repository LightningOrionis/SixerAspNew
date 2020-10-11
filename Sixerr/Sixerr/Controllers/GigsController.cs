using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sixerr.Data;
using Sixerr.Models;

namespace Sixerr.Controllers
{
    public class GigsController : Controller
    {
        private readonly AppDbContext _context;

        public GigsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Gigs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gigs.ToListAsync());
        }

        // GET: Gigs/Details/5
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gig = await _context.Gigs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gig == null)
            {
                return NotFound();
            }

            return View(gig);
        }

        // GET: Gigs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gigs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Price,Photo,Status,CreateTime,Category")] Gig gig)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gig);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gig);
        }

        // GET: Gigs/Edit/5
        public async Task<IActionResult> Edit(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gig = await _context.Gigs.FindAsync(id);
            if (gig == null)
            {
                return NotFound();
            }
            return View(gig);
        }

        // POST: Gigs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(uint id, [Bind("Id,Title,Description,Price,Photo,Status,CreateTime,Category")] Gig gig)
        {
            if (id != gig.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gig);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GigExists(gig.Id))
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
            return View(gig);
        }

        // GET: Gigs/Delete/5
        public async Task<IActionResult> Delete(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gig = await _context.Gigs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gig == null)
            {
                return NotFound();
            }

            return View(gig);
        }

        // POST: Gigs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(uint id)
        {
            var gig = await _context.Gigs.FindAsync(id);
            _context.Gigs.Remove(gig);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GigExists(uint id)
        {
            return _context.Gigs.Any(e => e.Id == id);
        }
    }
}
