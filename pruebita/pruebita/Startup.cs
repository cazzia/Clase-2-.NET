using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebita.Startup))]
namespace pruebita
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
