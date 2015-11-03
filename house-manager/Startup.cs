using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(house_manager.Startup))]
namespace house_manager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
