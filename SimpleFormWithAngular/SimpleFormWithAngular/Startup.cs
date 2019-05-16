using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleFormWithAngular.Startup))]
namespace SimpleFormWithAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
