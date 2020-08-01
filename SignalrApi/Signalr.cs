using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task send(object username, object message)
        {
            await Clients.All.SendAsync("messageReceived", username, message);
        }
        public async Task send2(object username, object message)
        {
            await Clients.All.SendAsync("messageReceived", username, message);
        }
    }
}