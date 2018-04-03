using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddingTheme.Startup))]
namespace AddingTheme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
