using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sixerr.Data;
using Sixerr.Models;
using Sixerr.ViewModels;

namespace Sixerr.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> userManager;

        public ReviewsController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create(uint gid)
        {
            ViewBag.gid = gid;
            return View();
        }

        [HttpPost]
        public IActionResult Create(uint gid, ReviewViewModel model)
        {
            var r = new Review
            {
                Author = _context.Profiles.First(p => p.User.Id == userManager.GetUserId(HttpContext.User)),
                Gig = _context.Gigs.Find(gid),
                Text = model.Text
            };
            _context.Reviews.Add(r);
            _context.SaveChanges();
            return RedirectToAction("Details", "Gigs", new { id = gid });
        }
    }
}
