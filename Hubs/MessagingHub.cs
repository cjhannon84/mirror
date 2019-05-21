using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace magicmirror.Hubs
{
    public class MessagingHub : Hub
    {
        public async Task SendMessage(string message) => await Clients.All.SendAsync("ReceiveMessage", message);
    }
}
