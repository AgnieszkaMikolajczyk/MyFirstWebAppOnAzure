using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstWebAppOnAzure.Startup))]
namespace MyFirstWebAppOnAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
