using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net;

namespace ExerciseFromVideos.Hubs
{
    public class Chat : Hub
    {
        public void SendMessage(string message)
        {
            string finalMessage = $"Message from {this.Context.User.Identity.Name}: {message}";
            this.Clients.All.newMessage(finalMessage);

            //taka scrapvame informaciq ot sait
            WebClient webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri("http://trader.bg"));

        }

        public void JoinRoom(string roomName)
        {
            //add to database this.Context.User.name with roomName
            this.Groups.Add(this.Context.ConnectionId, roomName);
        }

        public override Task OnConnected()
        {
            if (this.Context.User.Identity.Name== "")
            {
                this.Groups.Add(this.Context.ConnectionId, "get from db");
            }

            return base.OnConnected();
        }

        public void SendMessageToRoom(string message, string roomName)
        {
            string finalMessage = $"Message from {this.Context.User.Identity.Name}: {message}";
            this.Clients.Group(roomName).newMessageToRoom(finalMessage);
        }
    }
}