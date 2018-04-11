using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEssentialsDemo.Startup))]
namespace MVCEssentialsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
