using System.Configuration;
using Microsoft.Owin;
using MyUmbraco.Web;
using Owin;
using Umbraco.Core.Services;
using Umbraco.Web;

[assembly: OwinStartup("CustomOwinStartup", typeof(Startup))]
namespace MyUmbraco.Web
{
    public class Startup : UmbracoDefaultOwinStartup
    {
        public override void Configuration(IAppBuilder app)
        {
            base.Configuration(app);
            // todo: Add configuration
        }

        protected override void ConfigureServices(IAppBuilder app, ServiceContext services)
        {
            base.ConfigureServices(app, services);
            // todo: DI modules registration
        }

        protected override void ConfigureMiddleware(IAppBuilder app)
        {
            base.ConfigureMiddleware(app);
            // todo: runtime
        }
    }
}