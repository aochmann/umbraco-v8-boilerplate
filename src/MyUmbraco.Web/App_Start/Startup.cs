using System;
using System.ComponentModel;
using System.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using LightInject;
using LightInject.Microsoft.DependencyInjection;
using LightInject.Mvc;
using Microsoft.AspNet.SignalR.Configuration;
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
                var intExample = AppSettings.Get<int>("intExample");
                var decimalExample = AppSettings.Get<decimal>("decimalExample");
                var dateTimeExample = AppSettings.Get<DateTime>("dateTimeExample");
                var stringExample = AppSettings.Get<string>("stringExample");
                var boolExample = AppSettings.Get<bool>("boolExample");
                var notExistingKeyExample = AppSettings.Get<bool>("notExistingKeyExample");
                var notExistingKey2Example = AppSettings.Get<string>("notExistingKeyExample");

            }
        }
    }

    public static class AppSettings
    {
        public static T Get<T>(string key)
        {
            var appSetting = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrWhiteSpace(appSetting))
            {
                // We can also introduce Exception Pattern (custom exceptions)
                // Depends on language version, we can use default instead of default(T)
                return default(T);
            }

            var converter = TypeDescriptor.GetConverter(typeof(T));
            return (T)converter.ConvertFromInvariantString(appSetting);
        }
    }
}