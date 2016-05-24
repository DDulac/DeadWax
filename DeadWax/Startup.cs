using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeadWax.Startup))]
namespace DeadWax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
