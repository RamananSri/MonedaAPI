using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceLayer
{
    public class ChatHub : Hub
    {
        public void SendMessage(string name, string message)
        {
            Clients.All.AddMessage(name, message);
        }
    }
}