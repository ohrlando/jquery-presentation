using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQuery_Presentation_Demo1_Proj.Startup))]
namespace jQuery_Presentation_Demo1_Proj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
