using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MotociWeb.Startup))]
namespace MotociWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
