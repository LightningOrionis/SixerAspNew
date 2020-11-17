using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sixerr.Data;
using Sixerr.Models;

namespace Sixerr.Controllers
{
    public class ChatController : Controller
    {
        private readonly AppDbContext _context;
        public ChatController(AppDbContext context)
        {
            _context = context;
        }

        [Route("chat")]
        public IActionResult Chat()
        {
            var messages = _context.Messages.ToList();
            messages.Reverse();
            return View(messages);
        }
    }
}
