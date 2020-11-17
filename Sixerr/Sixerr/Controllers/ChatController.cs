using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sixerr.Data;

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
        [Authorize]
        public IActionResult Chat()
        {
            var messages = _context.Messages.ToList();
            return View(messages);
        }
    }
}
