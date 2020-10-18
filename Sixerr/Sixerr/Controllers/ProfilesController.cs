using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sixerr.Data;

namespace Sixerr.Controllers
{
    public class ProfilesController : Controller
    {
        private AppDbContext _context;

        public ProfilesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> MyProfile()
        {
            throw new Exception();
            var profile = await _context.Profiles.FindAsync(1u); // current user!!!
            return View(profile);
        }

        public async Task<IActionResult> MyGigs()
        {
            var profile = await _context.Profiles.FindAsync(2u); // current user!!!
            var my_gigs = await _context.Gigs.Where(gig => gig.User.Id == profile.Id).ToListAsync();
            return View(my_gigs);
        }
    }
}
