using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace PRAKTIKUM3_22SA21A160.Hubs
{
    public class HelloWorld : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Send(string user, string message)
        {
            Clients.All.show(user, message);
        }

        public override Task OnConnected()
        {
            return Clients.All.connected();
        }

        public void SendFile(string user, string fileName, string fileData)
        {
            Clients.All.showFile(user, fileName, fileData);
        }
    }
}
