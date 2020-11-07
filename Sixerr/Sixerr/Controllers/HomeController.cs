using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Sixerr.Data;
using Sixerr.Models;
using Sixerr.Services;

namespace Sixerr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var gigs = await _context.Gigs
                            .Include(g => g.User)
                            .Include(g => g.User.User)
                            .Where(g => g.Status)
                            .ToListAsync();
            //string smth = _configuration.GetSection("Smth").Value;
            //ViewBag["ConfSmth"] = _configuration.GetSection("Smth").Value;
            //ViewBag.Conf = _configuration.GetSection("Smth").Value;
            return View(gigs);
        }       
    }
}
