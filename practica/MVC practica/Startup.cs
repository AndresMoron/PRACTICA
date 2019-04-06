using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_practica.Startup))]
namespace MVC_practica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
