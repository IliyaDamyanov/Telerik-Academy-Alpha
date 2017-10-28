using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExerciseFromVideos.Startup))]
namespace ExerciseFromVideos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
