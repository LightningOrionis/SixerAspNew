using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Sixerr.Data;
using Sixerr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sixerr.Services
{
    public class ChatHub : Hub
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ChatHub(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task Send(string message, string userName)
        {
            var chatMessage = new ChatMessage
            {
                Username = userName,
                Message = message
            };
            _context.Messages.Add(chatMessage);
            await _context.SaveChangesAsync();
            await Clients.All.SendAsync("Send", message, userName);
        }
    }
}
