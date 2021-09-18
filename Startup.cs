using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_template.Startup))]
namespace MVC_template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
