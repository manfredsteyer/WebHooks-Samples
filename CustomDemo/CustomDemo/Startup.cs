using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomDemo.Startup))]
namespace CustomDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
