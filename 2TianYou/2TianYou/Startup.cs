using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2TianYou.Startup))]
namespace _2TianYou
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
