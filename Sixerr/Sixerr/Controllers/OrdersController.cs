using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sixerr.Data;
using Sixerr.Models;

namespace Sixerr.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public OrdersController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create(long gig_id, string username)
        {
            var gig = _context.Gigs.Include(g => g.User.User)
                                    .First(g => gig_id == g.Id);                                   
            return View(gig);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(long id)
        {
            var order = new Order();
            var gig = _context.Gigs.Include(g => g.User)
                                   .First(g => g.Id == id);
            order.Gig = gig;
            order.Executor = gig.User;
            order.Orderer = _context.Profiles.First(p => p.User.Id == _userManager.GetUserId(HttpContext.User));
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult MyOrdered()
        {
            var profile = _context.Profiles.First(p => p.User.Id == _userManager.GetUserId(HttpContext.User));
            var ordered = _context.Orders.Include(o => o.Orderer)
                                         .Include(o => o.Executor)
                                         .Include(o => o.Orderer.User)
                                         .Include(o => o.Executor.User)
                                         .Include(o => o.Gig.User)
                                         .Include(o => o.Gig.User.User)
                                         .Where(o => o.Executor.Id == profile.Id)
                                         .ToList();
            return View(ordered);
        }

        [Authorize]
        public IActionResult MyOrders()
        {
            var profile = _context.Profiles.First(p => p.User.Id == _userManager.GetUserId(HttpContext.User));
            var orders =  _context.Orders.Include(o => o.Executor)
                                         .Include(o => o.Orderer)                                         
                                         .Include(o => o.Orderer.User)                                         
                                         .Include(o => o.Executor.User)
                                         .Include(o => o.Gig.User)
                                         .Include(o => o.Gig.User.User)
                                         .Where(o => o.Orderer.Id == profile.Id)
                                         .ToList();
            return View(orders);
        }
    }
}
