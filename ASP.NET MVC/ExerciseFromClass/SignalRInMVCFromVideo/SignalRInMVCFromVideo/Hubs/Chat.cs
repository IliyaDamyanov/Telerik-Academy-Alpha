using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SignalRInMVCFromVideo.Hubs
{
    public class Chat : Hub
    {
        public void SendMessage(string message)
        {
            string finalMessage = $"Message from {this.Context.User.Identity.Name}: {message}"; // taka ako e lognat samo shte dostypi
            //string finalMessage = $"Message from {this.Context.ConnectionId}: {message}";
            this.Clients.All.newMessage(finalMessage);
        }

        public void JoinRoom(string roomName)
        {
            //add to database this.Context.User.Name with roomname
            this.Groups.Add(this.Context.ConnectionId, roomName);
        }

        public override Task OnConnected()
        {
            if (this.Context.User.Identity.Name=="") //provarqvame dali e edi koi si
            {
                this.Groups.Add(this.Context.ConnectionId, "get from db"); //nqkvo ime i tuka
            }
            return base.OnConnected();
        }

        public void SendMessageToRoom(string message, string roomName)
        {
            string finalMessage = $"Message from {this.Context.User.Identity.Name}: {message}";
            //string finalMessage = $"Message from {this.Context.ConnectionId}: {message}";
            this.Clients.Group(roomName).newMessageToRoom(finalMessage);
        }
    }
}