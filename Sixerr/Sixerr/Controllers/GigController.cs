using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sixerr.Data;

namespace Sixerr.Controllers
{
    public class GigController : Controller
    {
        private AppDbContext _context;

        public GigController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Detail(uint? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var gig = await _context.Gigs.FindAsync(id);
            if (gig == null)
            {
                return View("no gig");
            }
            return View(gig);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(uint? id)
        {
            return View();
        }
    }
}
