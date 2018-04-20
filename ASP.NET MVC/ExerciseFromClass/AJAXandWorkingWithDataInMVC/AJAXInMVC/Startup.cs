using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AJAXInMVC.Startup))]
namespace AJAXInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
