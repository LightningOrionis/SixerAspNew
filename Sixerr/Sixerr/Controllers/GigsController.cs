using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
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
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<IdentityUser> userManager;

        public GigsController(AppDbContext context, IWebHostEnvironment webHostEnvironment, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            this.userManager = userManager;
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

            var reviews = await _context.Reviews.Where(review => review.Gig.Id == gig.Id).ToListAsync();
            ViewData["reviews"] = reviews;

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
        public async Task<IActionResult> Create([Bind("Title,Description,Price,GigImage,Status,Category")] GigViewModel gigViewModel)
        {
            string uniqueFileName = UploadedFile(gigViewModel);
            if (ModelState.IsValid)
            {
                Gig gig = new Gig
                {
                    Id = 1 + (uint)_context.Gigs.Count(),
                    CreateTime = DateTime.Now,
                    Title = gigViewModel.Title,
                    Category = gigViewModel.Category,
                    Status = gigViewModel.Status,
                    Description = gigViewModel.Description,
                    Price = gigViewModel.Price,
                    Photo = uniqueFileName,
                    User = _context.Profiles.First(p => p.User.Id == userManager.GetUserId(HttpContext.User))
                };
               
                _context.Add(gig);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gigViewModel);
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
        public async Task<IActionResult> Edit(uint id, [Bind("Title,Description,Price,Photo,Status,Category")] Gig gig)
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

        private string UploadedFile(GigViewModel model)
        {
            string uniqueFileName = null;

            if (model.GigImage != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.GigImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.GigImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
