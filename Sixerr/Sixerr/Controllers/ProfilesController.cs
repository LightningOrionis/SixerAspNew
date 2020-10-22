﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sixerr.Data;
using Sixerr.Models;

namespace Sixerr.Controllers
{
    public class ProfilesController : Controller
    {
        private AppDbContext _context;
        private readonly UserManager<IdentityUser> userManager;

        public ProfilesController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        public IActionResult MyProfile()
        {
            uint id_ = _context.Profiles
                .First(p => p.User.Id == userManager.GetUserId(HttpContext.User)).Id;
            return RedirectToAction("Details", new { id = id_ });
        }

        public async Task<IActionResult> MyGigs()
        {
            var current_user = await userManager.GetUserAsync(HttpContext.User);
            var p = _context.Profiles
                .First(p => p.User == current_user);           
            var my_gigs = await _context.Gigs
                .Where(gig => gig.User.Id == p.Id).ToListAsync();
            return View(my_gigs);
        }

        public async Task<IActionResult> Details(uint id)
        {
            var p = await _context.Profiles.FindAsync(id);
            return View(p);
        }
    }
}
