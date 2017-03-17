using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JukeBox.Startup))]
namespace JukeBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
