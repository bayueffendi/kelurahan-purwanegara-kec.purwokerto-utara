using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PRAKTIKUM3_22SA21A160.Startup1))]

namespace PRAKTIKUM3_22SA21A160
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
