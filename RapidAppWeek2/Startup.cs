using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RapidAppWeek2.Startup))]
namespace RapidAppWeek2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
