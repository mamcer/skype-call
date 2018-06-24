using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MvcApplication1.Models
{
    [HubName("skypeCallHub")]
    public class SkypeCallHub : Hub
    {
        public void SkypeCall(string userName)
        {
            Clients.Others.SkypeCallRequest(userName);
        }

        public void ClientNotification(string message)
        {
            Clients.Others.clientNotification(message);
        }
    }
}