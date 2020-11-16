using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Create(Gig gig)
        {
            
            return View(gig);
        }

        [HttpPost]
        public async Task<IActionResult> Create(long id)
        {
            var order = new Order();
            var gig = _context.Gigs.Find(id);
            order.Gig = gig;
            order.Executor = gig.User;
            order.Orderer = _context.Profiles.First(p => p.User.Id == _userManager.GetUserId(HttpContext.User));
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
