using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRInMVCFromVideo.Hubs
{
    public class Chat :Hub
    {
        public void SendMessage(string message)
        {
            string finalMessage = $"Message from {this.Context.ConnectionId}: {message}";
            this.Clients.All.newMessage(finalMessage);
        }
    }
}