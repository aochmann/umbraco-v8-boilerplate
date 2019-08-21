using Microsoft.Owin;
using MyUmbraco.Web;
using Owin;
using Umbraco.Web;


[assembly: OwinStartup(typeof(Startup))]
namespace MyUmbraco.Web
{
    public class Startup : UmbracoDefaultOwinStartup
    {
        public override void Configuration(IAppBuilder app)
        {
            base.Configuration(app);
            // todo: Add configuration
        }
    }
}