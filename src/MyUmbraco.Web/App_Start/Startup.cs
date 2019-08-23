using System.Web.Http;
using System.Web.Mvc;
using LightInject;
using LightInject.Microsoft.DependencyInjection;
using LightInject.Mvc;
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
        protected IServiceContainer Container { get; set; }
        public override void Configuration(IAppBuilder app)
        {
            base.Configuration(app);
            // todo: Add configuration
        }

        protected override void ConfigureServices(IAppBuilder app, ServiceContext services)
        {
            base.ConfigureServices(app, services);
            Container = new ServiceContainer(ContainerOptions.Default.WithMicrosoftSettings());

            Container.EnableMvc();
            Container.EnablePerWebRequestScope();
            Container.EnableWebApi(GlobalConfiguration.Configuration);

            DependencyResolver.SetResolver(new LightInjectMvcDependencyResolver(Container)); //todo: better dependency resolver - nuget package
        }

        protected override void ConfigureMiddleware(IAppBuilder app)
        {
            base.ConfigureMiddleware(app);

            using (var scope = Container.BeginScope())
            {
                // todo: Initializer
            }
        }
    }
}