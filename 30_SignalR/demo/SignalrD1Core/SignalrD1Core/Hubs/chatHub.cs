using Microsoft.AspNetCore.SignalR;
using SignalrD1Core;
namespace SignalrD1Core.Hubs
{
    public class chatHub:Hub
    {
        chatContext db;
        public chatHub(chatContext db)
        {
            this.db = db;
        }
        
        public void sendmessage(string name ,string mess)
        {
            Clients.All.SendAsync("newmess", name, mess);

            message m = new message() { name = name, txt = mess };
            db.messages.Add(m);
            db.SaveChanges();
           
        }

    }
}
