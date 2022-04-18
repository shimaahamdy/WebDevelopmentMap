using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace signalrD1
{
    [HubName("chat")]
    public class chatHub : Hub
    {
      public void sendMessage(string name , string mess)
        {
            //savedb

            Clients.All.newmessage(name, mess);
        }
    }
}