using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Team404_v2.Startup))]
namespace Team404_v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
