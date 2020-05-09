using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobApplicationExample.Startup))]
namespace JobApplicationExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
