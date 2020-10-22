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
        public IActionResult Create(uint id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(uint id, ReviewViewModel model)
        {
            var r = new Review
            {
                Id = _context.Reviews.Count() + 1,
                Author = _context.Profiles.First(p => p.User.Id == userManager.GetUserId(HttpContext.User)),
                Gig = _context.Gigs.Find(id),
                Text = model.Text
            };
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
