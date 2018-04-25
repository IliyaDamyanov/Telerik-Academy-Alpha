using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRInMVCFromVideo.Startup))]
namespace SignalRInMVCFromVideo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}
