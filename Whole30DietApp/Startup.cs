using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Whole30DietApp.Startup))]
namespace Whole30DietApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
