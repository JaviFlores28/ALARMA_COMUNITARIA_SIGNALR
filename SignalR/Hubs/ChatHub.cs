using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Others.SendAsync("broadcastMessage", name, message);
        }
    }
}